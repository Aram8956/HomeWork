namespace Shape;

public abstract class Shapes
{
    protected abstract void Draw();
    protected abstract void Surface();

    public void Print()
    {
        Surface();
        Draw();
    }
}