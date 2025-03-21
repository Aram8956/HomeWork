namespace Translate;

public class Russian: Translator
{
    private string[] rwords = new string[]
    {
        "Яблоко", "Банан", "Апельсин", "Манго", "Ананас",
        "Виноград", "Клубника", "Вишня", "Арбуз", "Персик"
    };

    public override void Translate(string text)
    {
        for (int i = 0; i < rwords.Length; i++)
        {
            if (text.ToLower() == words[i].ToLower())
            {
                Console.WriteLine($"{rwords[i]}");
                return;
            }
        }
    }
}