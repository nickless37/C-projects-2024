using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        phrase = phrase.Replace("-", " ").Replace("_", " ");

        phrase = Regex.Replace(phrase, @"[^\w\s]", "");

        string[] words = phrase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string acronym = "";
        foreach (string word in words)
        {
            acronym += char.ToUpper(word[0]);
        }

        return acronym;
    }
}
class Program
{
    static void Main()
    {

        string phrase1 = Console.ReadLine();

        Console.WriteLine(Acronym.Abbreviate(phrase1));
    }
}