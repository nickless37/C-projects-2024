using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        char[] result = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                result[i] = (char)((c + shiftKey - offset) % 26 + offset);
            }
            else
            {
                result[i] = c;
            }
        }

        return new string(result);
    }
}
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] parts = input.Split(' ', 2);  

        string rotString = parts[0].Substring(3);
        if (!int.TryParse(rotString, out int shiftKey))
        {
            Console.WriteLine("Invalid rotation key.");
            return;
        }

        string text = parts[1];

        Console.WriteLine(RotationalCipher.Rotate(text, shiftKey));
    }
}