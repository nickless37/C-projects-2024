using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;


public interface ITransport
{
    void Name();
    void Deliver();
    void Use();
}

///////////////////// factory moduls

/*
шаблон:
public clase назва : назва загального інтерфейсу
public властивість 1 {}
public властивість 2 {}
public властивість 3 {}
*/

public class Car : ITransport   
{
    public void Name() 
    {
        Console.WriteLine("car");
    } 
    public void Deliver()
    {
        Console.WriteLine("delivering by car.");
    }
    public void Use()
    {
        Console.WriteLine("use roads");
    }
}

public class Ship : ITransport
{
    public void Name()
    {
        Console.WriteLine("ship");
    }
    public void Deliver()
    {
        Console.WriteLine("delivering by ship");
    }
    public void Use()
    {
        Console.WriteLine("use seas");
    }
}
public class Plane : ITransport
{
    public void Name()
    {
        Console.WriteLine("plane");
    }
    public void Deliver()
    {
        Console.WriteLine("delivering by plane");
    }
    public void Use()
    {
        Console.WriteLine("use air");
    }
}

////////////////////////////////////


public class TransportFactory
{
    public static ITransport CreateTransport(string name)
    {
        switch (name.ToLower())
        {
            case "car":
                return new Car();
            case "ship":
                return new Ship();
            case "plane":
                return new Ship();
            default:
                throw new ArgumentException("Input error");
        }
    }
}

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        ITransport transport = TransportFactory.CreateTransport(input);
        transport.Name();
        transport.Deliver();
        transport.Use();
    }
}
