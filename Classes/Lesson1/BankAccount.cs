namespace Program;


class BankAccount
{
    public string name;
    public int money;

    public BankAccount(string name, int money)
    {
        this.name = name;
        this.money = money;
    }

    public BankAccount(string name)
    {
        this.name = name;
        money = 0;
    }

    public override string ToString()
    {
        return $"Name: {name}, Money: {money}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is BankAccount other)
        {
            return name == other.name;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return name.GetHashCode();
    }

    public static BankAccount operator +(BankAccount our, int amount)
    {
        return new BankAccount(our.name, our.money + amount);
    }

    public static BankAccount operator -(BankAccount our, int amount)
    {
        if (amount > our.money) {
            Console.WriteLine("Not enough money to withdraw!");
            return new BankAccount(our.name, our.money);
        }

        return new BankAccount(our.name, our.money - amount);
    }

    public static bool operator >(BankAccount our, BankAccount other)
    {
        if (our.money > other.money)
        {
            return true;
        }
        return false;
    }

    public static bool operator <(BankAccount our, BankAccount other)
    {
        if (our.money > other.money)
        {
            return false;
        }
        return true;
    }
    public static bool operator >=(BankAccount our, BankAccount other)
    {
        if (our.money >= other.money)
        {
            return false;
        }
        return true;
    }

    public static bool operator <=(BankAccount our, BankAccount other)
    {
        if (our.money >= other.money)
        {
            return true;
        }
        return false;
    }
}


static class Prog
{
    static void Main()
    {
        BankAccount nor = new BankAccount("Aram");
        BankAccount hin = new BankAccount("Hakob", 100);
        Console.WriteLine(nor.ToString());
        Console.WriteLine(hin.ToString());
        nor += 500;
        hin -= 10;
        if (nor > hin)
        {
            Console.WriteLine("Nory kruma");
        }
        else
        {
            Console.WriteLine("Gna ashxati");
        }
    }
}
