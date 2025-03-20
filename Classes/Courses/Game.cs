namespace Class;

public class Game: Course
{
    public string engine { get; private set; }

    public Game(string name, int quantity, Module[] modules, string engine) : base(name, quantity, modules)
    {
        this.engine = engine;
    }
}