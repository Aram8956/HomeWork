namespace Shape;

public class Square: Shapes
{
    private int side;

    public Square(int side)
    {
        this.side = side;
    }

    protected override void Surface()
    {
        Console.WriteLine($"Square: S = {side * side}");
    }

    protected override void Draw()
    {
        for (int i = 0; i < side; i++)
        {
            for (int j = 0; j < side; j++)
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