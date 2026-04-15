using System;
using System.Linq;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = word.ToLower();
        var seenLetters = new HashSet<char>();

        foreach (char c in word)
        {
            if (c == ' ' || c == '-')
                continue;
            if (seenLetters.Contains(c))
                return false;
            seenLetters.Add(c);
        }

        return true;
    }
}
class Program
{
    static void Main()
    {
        bool result = Isogram.IsIsogram(Console.ReadLine());
        Console.WriteLine(result);
    }
}