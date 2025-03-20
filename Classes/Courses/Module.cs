namespace Class;

public class Module
{
    public string name;
    public int duration;

    public Module(string name, int duration)
    {
        this.name = name;
        this.duration = duration;
    }

    public Module(Module module)
    {
        this.name = module.name;
        this.duration = module.duration;
    }
}