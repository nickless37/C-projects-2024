using System;
public interface ITransport
{
    void Deliver();
}
public class Car : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Автомобіль доставляє товар."); 
    }
}

public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Корабель доставляє товар.");
    }
}

public abstract class TransportFactory        
{
    public abstract ITransport CreateTransport();

    public void Deliver()
    {
        var transport = CreateTransport();
        transport.Deliver();
    }
}

public class CarFactory : TransportFactory
{
    public override ITransport CreateTransport()
    {
        return new Car();
    }
}

public class ShipFactory : TransportFactory
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Використання фабрики для створення автомобіля
        TransportFactory carFactory = new CarFactory();
        carFactory.Deliver(); // Виведе: "Автомобіль доставляє товар."
        // Використання фабрики для створення корабля
        TransportFactory shipFactory = new ShipFactory();
        shipFactory.Deliver(); // Виведе: "Корабель доставляє товар."
    }
}
