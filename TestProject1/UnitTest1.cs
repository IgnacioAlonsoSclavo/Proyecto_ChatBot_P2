namespace TestProject1;
using Proyecto_ChatBot_P2;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1(){
        Vendedor pepito = new Vendedor("pepito","lacra","999999","pepito@gmail.com");
        pepito.AñadirCliente(out Cliente fulanito,"fulanito", "rodriguez", "9998888", "fulanopinto@gmail.com");
        pepito.EnviarMsg(fulanito,"Hola");
        Equals(pepito.Name, "pepito");
    }
    
    [Test]
    public void Test2()
    {
        Vendedor pepito = new Vendedor("pepito","lacra","999999","pepito@gmail.com");
        pepito.AñadirCliente(out Cliente fulanito,"fulanito", "rodriguez", "9998888", "fulanopinto@gmail.com");
        pepito.EnviarMsg(fulanito,"Hola");
        Equals(CRM.mensajes[0], (pepito, fulanito, "Hola"));
    }
    
    [Test]
    public void Test3()
    {
        Vendedor pepito = new Vendedor("pepito","lacra","999999","pepito@gmail.com");
        pepito.AñadirCliente(out Cliente fulanito,"fulanito", "rodriguez", "9998888", "fulanopinto@gmail.com");
        pepito.EnviarMsg(fulanito,"Hola");
        fulanito.EnviarMsg("Hola x2");
        Equals(CRM.mensajes.Count, 2);
    }
    
    [Test]
    public void Test4()
    {
        Vendedor unVendedor = new Vendedor("Paco", "Carlos", "038244912", "elpaquito@gmail.com");
        unVendedor.AñadirCliente(out Cliente unCliente, "Pepe", "Alonso", "092567345", "elpepito@gmail.com");
        Equals(unVendedor.Clientes.Count, 1);
    }
    
    [Test]
    public void Test5()
    {
        Vendedor unVendedor = new Vendedor("Peco", "Carlos", "038244912", "elpaquito@gmail.com");
        unVendedor.AñadirCliente(out Cliente unCliente, "Pepe", "Alonso", "092567345", "elpepito@gmail.com") ;
        CRM.VendedorCliente(unVendedor);
        Equals(CRM.vendedorClientes.Count, 1);
    }
    
    [Test]
    public void Test6()
    {
        Vendedor unVendedor = new Vendedor("Pico", "Carlos", "038244912", "elpaquito@gmail.com");
        unVendedor.AñadirCliente(out Cliente unCliente, "Pepe", "Alonso", "092567345", "elpepito@gmail.com") ;
        unVendedor.AñadirCliente(out Cliente otroCliente, "Pipe", "Ozono", "098767345", "elpiprpito@gmail.com") ;
        CRM.ListaDeClientes(unCliente);
        CRM.ListaDeClientes(otroCliente);
        Equals(CRM.listaDeClientes.Count, 2);
    }
    
    [Test]
    public void Test7()
    {
        Vendedor unVendedor = new Vendedor("Poco", "Carlos", "038244912", "elpaquito@gmail.com");
        unVendedor.AñadirCliente(out Cliente unCliente, "Pepe", "Alonso", "092567345", "elpepito@gmail.com");
        CRM.ListaDeVendedores(unVendedor);
        Equals(CRM.listaDeVendedores.Count, 1);
    }
}