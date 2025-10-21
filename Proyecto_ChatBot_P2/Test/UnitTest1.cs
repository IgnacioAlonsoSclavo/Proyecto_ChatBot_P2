using DefaultNamespace;
namespace Proyecto_ChatBot_P2;
using NUnit.Framework;
 
//TEST
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Vendedor pepito = new Vendedor("pepito","lacra","999999","pepito@gmail.com");
        pepito.AñadirCliente(out Cliente fulanito,"fulanito", "rodriguez", "9998888", "fulanopinto@gmail.com");
        pepito.EnviarMsg(fulanito,"Hola");
        Assert.Equals(fulanito.Name, "fulanito");
    }
    [Test]
    public void Test2()
    {
        Vendedor pepito = new Vendedor("pepito","lacra","999999","pepito@gmail.com");
        pepito.AñadirCliente(out Cliente fulanito,"fulanito", "rodriguez", "9998888", "fulanopinto@gmail.com");
        pepito.EnviarMsg(fulanito,"Hola");
        Assert.Equals(pepito.Mail, "pepito@gmail.com");
    }
}
