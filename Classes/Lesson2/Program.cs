namespace tank;


public class WaterTank
{
    private double capacity;
    public double current { get; set; }

    
    public WaterTank(double capacity, double current)
    {
        if (current > capacity)
        {
            this.capacity = current;
            this.current = current;
        }
        else if (current <= capacity)
        {
            this.capacity = capacity;
            this.current = current;
        }
        else if (current <= 0)
        {
            this.current = 0;
            this.capacity = capacity;
        }
    }

    public static WaterTank operator +(WaterTank tank1, WaterTank tank2)
    {
        double final = tank1.current + tank2.current;
        if (final > tank1.capacity)
        {
            if (final > tank2.capacity)
            {
                return new WaterTank(final, final);
            }
            return new WaterTank(tank2.capacity, final);
        }
        else
        {
            return new WaterTank(tank1.capacity, final);
        }
    }

    public static WaterTank operator -(WaterTank tank1, WaterTank tank2)
    {
        double final;
        if (tank1.current > tank2.current)
        {
            final = tank1.current - tank2.current;
            return new WaterTank(tank1.capacity, final);
        }

        Console.WriteLine("Cant get that much water");
        return tank1;
    }

    public override string ToString()
    {
        return $"Maximum Capacity: {capacity}\nCurrent Level: {current}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        WaterTank tank1 = new WaterTank(10.0, 5.0);
        WaterTank tank2 = new WaterTank(8.0, 5.0);
        WaterTank tank3 = tank1 + tank2;
        Console.WriteLine(tank1.ToString());
        Console.WriteLine(tank2.ToString());
        Console.WriteLine(tank3.ToString());
        
        tank3 -= tank1;
        Console.WriteLine(tank3.ToString());
    }
}