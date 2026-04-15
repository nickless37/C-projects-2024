using System;
using System.Text.RegularExpressions;

public static class PigLatin
{
    public static string Translate(string phrase)
    {
        string[] words = phrase.Split(' '); 
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = TranslateWord(words[i]); 
        }

        return string.Join(" ", words); 
    }

    private static string TranslateWord(string word)
    {
        string vowels = "aeiou";

        
        if (vowels.Contains(word[0]) || word.StartsWith("xr") || word.StartsWith("yt"))
        {
            return word + "ay";
        }
        else if (Regex.IsMatch(word, @"^[^aeiou]+"))
        {
            if (Regex.IsMatch(word, @"^[^aeiou]*qu"))
            {
                int quIndex = word.IndexOf("qu") + 2;
                return word.Substring(quIndex) + word.Substring(0, quIndex) + "ay";
            }
            if (Regex.IsMatch(word, @"^[^aeiou]+y"))
            {
                int yIndex = word.IndexOf('y');
                return word.Substring(yIndex) + word.Substring(0, yIndex) + "ay";
            }
            int vowelIndex = Regex.Match(word, @"[aeiou]").Index;
            return word.Substring(vowelIndex) + word.Substring(0, vowelIndex) + "ay";
        }

        return word; 
    }
}
public class Program
{
    static void Main()
    {
        string result = PigLatin.Translate(Console.ReadLine());
        Console.WriteLine(result);
    }
}