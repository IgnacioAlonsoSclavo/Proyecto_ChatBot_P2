﻿using DefaultNamespace;

namespace Proyecto_ChatBot_P2;

public class CRM
{
    public static Dictionary<Vendedor, List<Cliente>> vendedorClientes = new Dictionary<Vendedor, List<Cliente>>();
    public static List<IUsuario> listaDeClientes = new List<IUsuario>();
    public static List<IUsuario> listaDeVendedores = new List<IUsuario>();
    public static string Mensaje { get; set; }
    
    // Creo lista de mensajes (remitente, destinatario, mensaje)
    public static List<(IUsuario Remitente, IUsuario Destinatario, string Mensaje)>
        mensajes = new List<(IUsuario, IUsuario, string)>();

    //--Realiza un diccionario con los vendedores y su lista de clientes--//
    public static void VendedorCliente(Vendedor vendedor)
    { 
        vendedorClientes.Add(vendedor, vendedor.Clientes);
    }

    public static void PrintVendedorCliente()
    {
        Console.WriteLine($"{vendedorClientes}");
    }
    //--------------------------------------------------------------------//
    //--Realiza una lista de todos los vendedores registrados--//
    public static void ListaDeClientes(Cliente unCliente)
    {
        listaDeClientes.Add(unCliente);
    }

    public static void PrintListaDeClientes()
    {
        Console.WriteLine($"{listaDeClientes}");
    }
    //---------------------------------------------------------//
    //--Realiza una lista de todos los vendedores registrados--//
    
    public static void ListaDeVendedores(Vendedor unVendedor)
    {
        listaDeVendedores.Add(unVendedor);
    }

    public static void PrintListaDeVendedores()
    {
        Console.WriteLine($"{listaDeVendedores}");
    }
    //---------------------------------------------------------//
    // Metodo estatico para enviar un mensaje
    public static void SendMsg(IUsuario remitente,IUsuario destinatario, string msg)
    {
        // agrega el mensaje con los datos a la lista de mensajes
        mensajes.Add((remitente, destinatario, msg)); 
    }
    
    // Metodo para mostrar historial de todos los mensajes
    public static void MostrarMensajes()
    {
        //itero entre todos los mensajes
        foreach ((IUsuario Remitente, IUsuario Destinatario, string Mensaje) mensaje in mensajes)
        {
            //los muestro en consola con formato para que quede mejor visualmente
            Console.WriteLine($"{mensaje.Remitente.Name} -> {mensaje.Destinatario.Name}: {mensaje.Mensaje}");
        }
    }

    // Metodo para mostrar historial de mensajes de un remitente específico
    public static void MostrarMensajesPorRemitente(IUsuario remitente)
    {
        //itero entre todos los mensajes
        foreach ((IUsuario Remitente, IUsuario Destinatario, string Mensaje) mensaje in mensajes)
        {
            //si el remitente es igual al que estoy buscando se muestra en consola el mensaje con todos sus datos.
            if (mensaje.Remitente.Equals(remitente))
            {
                Console.WriteLine($"{mensaje.Remitente.Name} -> {mensaje.Destinatario.Name}: {mensaje.Mensaje}");
            }
        }
    }

    // Metodo para mostrar historial de mensajes hacia un destinatario específico
    public static void MostrarMensajesPorDestinatario(IUsuario destinatario)
    {
        //itero entre todos los mensajes
        foreach ((IUsuario Remitente, IUsuario Destinatario, string Mensaje) mensaje in mensajes)
        {
            //si el destinatario es igual al que estoy buscando se muestra en consola el mensaje con todos sus datos.
            if (mensaje.Destinatario.Equals(destinatario))
            {
                Console.WriteLine($"{mensaje.Remitente.Name} -> {mensaje.Destinatario.Name}: {mensaje.Mensaje}");
            }
        }
    }
    // Metodo para mostrar el historial de mensajes entre 2 personas.
    public static void MostrarMensajesEntre(IUsuario P1, IUsuario P2)
    {
        //itero entre cada mensaje
        foreach ((IUsuario Remitente, IUsuario Destinatario, string Mensaje) mensaje in mensajes)
        {
            //en caso de que el remitente sea p1 o p2 y el destinatario sea p1 o p2 se muestra en consola.
            if ((mensaje.Remitente.Equals(P1) && mensaje.Destinatario.Equals(P2)) ||
                (mensaje.Remitente.Equals(P2) && mensaje.Destinatario.Equals(P1)))
            {
                Console.WriteLine($"{mensaje.Remitente.Name} -> {mensaje.Destinatario.Name}: {mensaje.Mensaje}");
            } 
        }
    }
}