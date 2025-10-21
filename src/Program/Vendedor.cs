namespace DefaultNamespace;

public class Vendedor: IUsuario
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<string> Inbox { get; set; }
        public List<string> HistoryMsg{ get; set; }
        public Tuple <string, string> Contact { get; set; }
        public List<Cliente> Clientes = new List<Cliente>();
    
        public Vendedor(string name, string surname, string numTelefono, string mail)
        {
            this.Name = name;
            this.Surname = surname;
            this.Contact = new Tuple<string, string>(numTelefono, mail);
        }
    
        //--Realiza una lista de los clientes del Vendedor--//
        public void ClientList(Cliente unCliente)
        {
            Clientes.Add(unCliente);
        }

        public void PrintClientList()
        {
            Console.WriteLine($"{Clientes}");
        }
        public void EnviarMsg(IUsuario cliente, string message)
        {
            bool cliente_en_lista = false;
            foreach (Cliente Cliente in Clientes) 
            { if (Cliente == cliente){CRM.SendMsg(this,cliente,message); cliente_en_lista = true; ;}}
            if (!cliente_en_lista){Console.WriteLine("No se encontro el cliente en tu lista");}
        
        }

        public void AñadirCliente(out Cliente cliente, string nombre, string apellido, string telefono, string email)
        {
            cliente = new Cliente( nombre,  apellido, telefono,  email, this);
            Clientes.Add(cliente);
        }

        public void EditarCliente(IUsuario cliente, string Name, string Surname, string NumTelefono, string Mail)
        {
            bool cliente_en_lista = false;
            foreach (Cliente Cliente in Clientes)
            {
                if (Cliente == cliente)
                {
                    cliente_en_lista = true; 
                    Cliente.Name = Name;
                    Cliente.Surname = Surname;
                    Cliente.numTelefono = NumTelefono;
                    Cliente.Mail = Mail;
                }
            }

            if (!cliente_en_lista)
            {
                Console.WriteLine("No se encontro el cliente en tu lista de clientes");
            }
        }
        //--------------------------------------------------//      
    }
