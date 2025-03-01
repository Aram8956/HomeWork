namespace DigitalInk;


public class InkReservoir
{
    public string color { get; set; }
    private double inkAmount { get; set; }

    public InkReservoir(string color, double inkAmount)
    {
        this.color = color;
        if (inkAmount <= 0)
        {
            this.inkAmount = 0;
        }
        else
        {
            this.inkAmount = inkAmount;
        }
    }

    public static InkReservoir operator +(InkReservoir a, InkReservoir b)
    {
        if (a.color != b.color)
        {
            Console.WriteLine("Colors are different");
            return null;
        }

        double final = a.inkAmount + b.inkAmount;
        return new InkReservoir(a.color, final);
    }

    public static InkReservoir operator -(InkReservoir a, double use)
    {
        if (a.inkAmount < use)
        {
            Console.WriteLine("Ink has ended!");
            return new InkReservoir(a.color, 0);
        }
        
        Console.Write("Using ink for some papaerwork");
        for (int i = 0; i < 3; ++i)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine();
        Console.WriteLine("Done!");
        return new InkReservoir(a.color, a.inkAmount - use);
    }

    public override string ToString()
    {
        return $"Color: {color}, Amount: {inkAmount}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        InkReservoir inkReservoir1 = new InkReservoir("Red", 12.0);
        InkReservoir inkReservoir2 = new InkReservoir("Blue", 0.5);

        InkReservoir inkReservoir3 = inkReservoir1 + inkReservoir2;
        if (inkReservoir3 != null)
        {
            Console.WriteLine(inkReservoir3.ToString());
        }

        inkReservoir1 = inkReservoir1 - 10.0;
        Console.WriteLine(inkReservoir1.ToString());
    }
}