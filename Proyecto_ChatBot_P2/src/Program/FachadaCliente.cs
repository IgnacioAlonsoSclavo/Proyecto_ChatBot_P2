namespace Proyecto_ChatBot_P2;

public class FachadaCliente
{
    private Cliente _cliente;

    public FachadaCliente(string nombre, string apellido, string telefono, string mail, Vendedor vendedor)
    {
        _cliente = new Cliente(nombre, apellido, telefono, mail,  vendedor);
    }
    
// Método para enviar mensajes
    public void EnviarMensaje(string mensaje)
    {
        _cliente.EnviarMsg(mensaje);
    }
    
// Método para revisar mensajes
    public void VerMensajesRecibidos()
    {
        if (_cliente.Inbox == null || _cliente.Inbox.Count == 0)
        {
            Console.WriteLine($"{_cliente.Name} no tiene mensajes nuevos.");
            return;
        }
        Console.WriteLine($"Mensajes recibidos por {_cliente.Name}:");
        foreach (string msg in _cliente.Inbox)
        {
            Console.WriteLine($"- {msg}");
        }
    }
    
// Método para ver un cliente
    public Cliente ObtenerCliente()
    {
        return _cliente;
    }
}