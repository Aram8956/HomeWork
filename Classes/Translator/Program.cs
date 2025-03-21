namespace Translate;

class Program
{
    static void Main(string[] args)
    {
        Translator[] words = new Translator[3];
        words[0] = new Spanish();
        words[1] = new French();
        words[2] = new Russian();
        foreach(Translator t in words){
            t.Translate("Banana");
        }
    }
}