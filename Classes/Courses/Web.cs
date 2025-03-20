namespace Class;

public class Web: Course
{
    public string Type{get; private set;}

    public Web(string name, int quantity, Module[] modules, string type) : base(name, quantity, modules)
    {
        this.Type = type;
    }
}