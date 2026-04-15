using System;

public class Clock
{
    private int hours;
    private int minutes;


    public Clock(int hours, int minutes)
    {
        int totalMinutes = hours * 60 + minutes;
        while (totalMinutes < 0)
        {
            totalMinutes += 1440;
        }
        this.hours = NormalizeHours(totalMinutes / 60);
        this.minutes = ((totalMinutes % 60) + 60) % 60; 
    }
    public Clock Add(int minutesToAdd)
    {
        int totalMinutes = this.hours * 60 + this.minutes + minutesToAdd;
        return new Clock(totalMinutes / 60, totalMinutes % 60);
    }


    public Clock Subtract(int minutesToSubtract)
    {
        int totalMinutes = this.hours * 60 + this.minutes - minutesToSubtract;
        while (totalMinutes < 0)
        {
            totalMinutes += 1440; 
        }
        return new Clock(totalMinutes / 60, totalMinutes % 60);
    }


    private int NormalizeHours(int hours)
    {
        return ((hours % 24) + 24) % 24;
    }


    public override bool Equals(object obj)
    {
        if (obj is Clock otherClock)
        {
            return this.hours == otherClock.hours && this.minutes == otherClock.minutes;
        }
        return false;
    }


    public override int GetHashCode()
    {
        return (hours * 60 + minutes).GetHashCode();
    }


    public override string ToString()
    {
        return $"{hours:D2}:{minutes:D2}";
    }
}
public class Program
{
    public static void Main()
    {

        var sut = new Clock(0, 0);
        var sutPlus1 = sut.Add(1);
        Console.WriteLine(sut);      //  00:00
        Console.WriteLine(sutPlus1); //  00:01
        Console.WriteLine(sut.Equals(sutPlus1)); //  False

        var clock = new Clock(10, 0);
        clock = clock.Subtract(130);
        Console.WriteLine(clock); //  07:50

        var clock2 = new Clock(3, 40);
        clock2 = clock2.Subtract(80);
        Console.WriteLine(clock2); //  02:20

        var clock3 = new Clock(22, 15);
        clock3 = clock3.Add(100);
        Console.WriteLine(clock3); //  23:55

        var clock4 = new Clock(0, 5);
        clock4 = clock4.Subtract(10);
        Console.WriteLine(clock4); //  23:55 
    }
}
