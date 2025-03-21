namespace Shape;

class Program
{
    static void Main(string[] args)
    {
        Shapes[] shapes = new Shapes[2];
        shapes[0] = new Square(4);
        shapes[1] = new Rectangle(4,6);
        foreach(Shapes s in shapes){
            s.Print();
        }
    }
}