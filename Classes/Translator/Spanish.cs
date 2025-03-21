namespace Translate;

public class Spanish: Translator
{
    public string[] swords = new string[]
    {
        "Manzana", "Plátano", "Naranja", "Mango", "Piña",
        "Uva", "Fresa", "Cereza", "Sandía", "Melocotón"
    };

    public override void Translate(string text)
    {
        for (int i = 0; i < swords.Length; i++)
        {
            if (text.ToLower() == words[i].ToLower())
            {
                Console.WriteLine($"{swords[i]}");
                return;
            }
        }
    }
}