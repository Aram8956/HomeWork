namespace Shape;

public class Rectangle: Shapes
{
    private int side;
    private int length;

    public Rectangle(int side, int length)
    {
        this.side = side;
        this.length = length;
    }

    protected override void Surface()
    {
        Console.WriteLine($"Rectangle: S = {side * length}");
    }

    protected override void Draw()
    {
        for (int i = 0; i < length; ++i)
        {
            for (int j = 0; j < side; ++j)
            {
                Console.Write("+ ");
            }
            Console.WriteLine();
        }
        
        for (int i = 0; i < 10; ++i)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }
}