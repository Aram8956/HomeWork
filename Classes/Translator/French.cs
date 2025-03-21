namespace Translate;

public class French: Translator
{
    private string[] fwords = new string[]
    {
        "Pomme", "Banane", "Orange", "Mangue", "Ananas",
        "Raisin", "Fraise", "Cerise", "Pastèque", "Pêche"
    };
    public override void  Translate(string text)
    {
        for (int i = 0; i < fwords.Length; i++)
        {
            if (text.ToLower() == words[i].ToLower())
            {
                Console.WriteLine($"{fwords[i]}");
                return;
            }
        }
    }
}