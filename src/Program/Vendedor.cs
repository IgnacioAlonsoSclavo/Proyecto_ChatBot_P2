namespace a;

public class Cliente : IUsuario
{
    public string Name {get; set;}
    public string Surname { get; set; }
    public string numTelefono { get; set; }
    public string Mail { get; set; }
    public Tuple <string, string> Contact { get; set; }
    public List<string> Inbox { get; set; }
    public List<string> HistoryMsg{ get; set; }
    public Vendedor UnVendedor { get; set; }

    public Cliente(string name, string surname, string numTelefono, string mail, Vendedor unVendedor)
    {
        this.Name = name;
        this.Surname = surname;
        this.Contact = new Tuple<string, string>(numTelefono, mail);
        this.UnVendedor = unVendedor;
        this.numTelefono = numTelefono;
        this.Mail = mail;
    }

    public void EnviarMsg(string msg)
    {
        CRM.SendMsg(this,this.UnVendedor,msg);
    }


}