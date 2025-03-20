namespace ParentChild;

class Program
{
    static void Main(string[] args)
    {
        Child[] child = new Child[10];
        for (int i = 0; i < 10; i++)
        {
            child[i] = new Child(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), new Parent(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())), new Parent(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
        }

        for (int i = 0; i < 10; i++)
        {
            if (child[i].AgeSum() < 70)
            {
                child[i].Print();
            }
        }

        int maxind = 0;
        for (int i = 0; i < 10; i++)
        {
            if (child[i].age > child[maxind].age)
            {
                maxind = i;
            }
        }
        Console.WriteLine(child[maxind].parent1.salary);

        int minind = 0;
        for (int i = 1; i < child.Length; i++)
        {
            if (child[i].age < child[minind].age)
            {
                minind = i;
            }
        }

        Child temp = new Child(child[minind]);
        child[minind] = child[maxind];
        child[maxind] = temp;
    }
}