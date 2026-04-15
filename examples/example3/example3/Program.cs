using System;
using System.Collections.Generic;

public interface IComponent
{
    void Display();
}

// лист
public class Leaf : IComponent
{
    private string name;

    public Leaf(string name)
    {
        this.name = name;
    }

    public void Display()
    {
        Console.WriteLine("leaf: " + name);
    }
}

// компонувальник
public class Composite : IComponent
{
    private string name;
    private List<IComponent> children = new List<IComponent>();

    public Composite(string name)
    {
        this.name = name;
    }

    public void Add(IComponent component)
    {
        children.Add(component);
    }

    public void Display()
    {
        Console.WriteLine("Composite: " + name);
        foreach (var child in children)
        {
            child.Display();
        }
    }
}

// Головна програма
public class Program
{
    public static void Main()
    {
        
        IComponent leaf1 = new Leaf("Лист 1");
        IComponent leaf2 = new Leaf("Лист 2");

        Composite composite = new Composite("Компонувальник 1");
        composite.Add(leaf1);
        composite.Add(leaf2);

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        composite.Display();
        Console.ResetColor();
    }
}