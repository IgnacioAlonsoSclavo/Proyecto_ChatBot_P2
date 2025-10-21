namespace EjemploClassCrm;

public class FachadaVendedor
{
    private Vendedor _vendedor;

    public FachadaVendedor(string nombre, string apellido, string telefono, string mail)
    {
        _vendedor = new Vendedor(nombre, apellido, telefono, mail);
    }
    
// Método para añadir un cliente
    public void CrearCliente(string nombre, string apellido, string telefono, string mail)
    {
        _vendedor.AñadirCliente(out Cliente cliente, nombre, apellido, telefono, mail);
        Console.WriteLine($"Cliente {cliente.Name} {cliente.Surname} agregado correctamente.");
    } 

// Método para enviar un mensaje
    public void EnviarMensaje(IUsuario cliente, string mensaje)
    {
        _vendedor.EnviarMsg(cliente, mensaje);
    }
    
// Método para editar un cliente
    public void EditarCliente(IUsuario cliente, string nombre, string apellido, string telefono, string mail)
    {
        _vendedor.EditarCliente(cliente, nombre, apellido, telefono, mail);
    }
    
// Método para ver la lista de clientes
    public void VerClientes()
    {
        _vendedor.VerListaDeClientes();
    }
    
// Método para obtener el vendedor
    public Vendedor ObtenerVendedor()
    {
        return _vendedor;
    }
}