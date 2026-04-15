
using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        if (year % 4 == 0)
        { 
            if (year % 100 != 0)
            {
                //Console.WriteLine("this is a leap year");
                return true;
            }
            else
            {
                if (year % 400 == 0)
                {
                    //Console.WriteLine("this is a leap year");
                    return true ;
                }
                else { return false; }
            }
        }
        else { return false; }
    }
    public static void Main()
    {
        bool result = IsLeapYear(2100);
        Console.WriteLine(result);
    }
}
/*static class Program 
{
    public static void Main()
    {
        bool result = IsLeapYear(1996);
    }
}*/