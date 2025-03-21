namespace Translate;

public abstract class Translator
{
    protected string[] words = new string[]
    {
        "Apple", "Banana", "Orange", "Mango", "Pineapple",
        "Grape", "Strawberry", "Cherry", "Watermelon", "Peach"
    }; 
    public abstract void Translate(string text);
}