

// Запит
public class Request
{
    public int Value { get; set; }
}

// Базовий клас обробника
public abstract class Handler
{
    protected Handler next;

    public void SetNext(Handler handler)
    {
        next = handler;
    }

    public abstract void Handle(Request request);
}

// Конкретний обробник 1
public class PositiveHandler : Handler
{
    public override void Handle(Request request)
    {
        if (request.Value > 0)
        {
            Console.WriteLine("PositiveHandler: Значення позитивне.");
        }
        else if (next != null)
        {
            next.Handle(request);
        }
    }
}

// Конкретний обробник 2
public class NegativeHandler : Handler
{
    public override void Handle(Request request)
    {
        if (request.Value < 0)
        {
            Console.WriteLine("NegativeHandler: Значення негативне.");
        }
        else if (next != null)
        {
            next.Handle(request);
        }
    }
}

// Конкретний обробник 3
public class ZeroHandler : Handler
{
    public override void Handle(Request request)
    {
        if (request.Value == 0)
        {
            Console.WriteLine("ZeroHandler: Значення дорівнює нулю.");
        }
        else if (next != null)
        {
            next.Handle(request);
        }
    }
}

// Головна програма
public class Program
{
    public static void Main(string[] args)
    {
        // Створюємо запит
        int n = int.Parse(Console.ReadLine());
        var request = new Request { Value = n};

        // Створюємо обробники
        var positiveHandler = new PositiveHandler();
        var negativeHandler = new NegativeHandler();
        var zeroHandler = new ZeroHandler();

        // Встановлюємо послідовність
        positiveHandler.SetNext(negativeHandler);
        negativeHandler.SetNext(zeroHandler);

        // Відправляємо запит до ланцюга
        positiveHandler.Handle(request);
    }
}

