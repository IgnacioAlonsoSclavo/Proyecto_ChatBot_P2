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
    
    [Test]
    public void Test8_SendMsg_AgregaMensaje()
    {
        CRM.mensajes.Clear(); //borro de pruebas anteriores
        Vendedor remitente = new Vendedor("Pan", "Flauta", "099999999", "pan@harina.com");
        remitente.AñadirCliente(out Cliente unCliente, "celiaco", "n1", "911", "noquieropan@celiaco.com");
        CRM.SendMsg(remitente, unCliente, "Mensaje de prueba");
        Assert.That(CRM.mensajes.Count, Is.EqualTo(1));
        Assert.That(CRM.mensajes[0].Remitente, Is.EqualTo(remitente));
        Assert.That(CRM.mensajes[0].Destinatario, Is.EqualTo(unCliente));
        Assert.That(CRM.mensajes[0].Mensaje, Is.EqualTo("Mensaje de prueba"));
    }
    
    [Test]
    public void Test9_VendedorCliente_AgregaDicc()
    {
        Vendedor vendedor = new Vendedor("Mario", "bros", "099123456", "mario@bros.com");
        vendedor.AñadirCliente(out Cliente cliente, "ford", "falcon", "1998", "ford@falcon.com");
        CRM.VendedorCliente(vendedor);
        Assert.That(CRM.vendedorClientes.ContainsKey(vendedor));
        Assert.That(CRM.vendedorClientes[vendedor].Count, Is.EqualTo(1));
    }
    [Test]
    public void Test10_ListaDeClientes_AgregaCliente()
    {
        Vendedor vendedor = new Vendedor("pedro", "picamadera", "099123456", "pedro@madera.com");
        vendedor.AñadirCliente(out Cliente cliente, "Pablo", "Torres", "098111111", "pablo@gmail.com");
        CRM.ListaDeClientes(cliente);
        Assert.That(CRM.listaDeClientes.Count, Is.EqualTo(1));
        Assert.That(CRM.listaDeClientes[0], Is.EqualTo(cliente));
    }
    [Test]
    public void Test11_ListaDeVendedores_AgregaVendedor()
    {
        Vendedor vendedor = new Vendedor("vendedor", "enojado", "666", "estoy@enojado.com");
        CRM.ListaDeVendedores(vendedor);
        Assert.That(CRM.listaDeVendedores.Count, Is.EqualTo(1));
        Assert.That(CRM.listaDeVendedores[0], Is.EqualTo(vendedor));
    }
    
}