namespace ParentChild;

public class Parent
{
    public string name {get;}
    public int age {get;}
    public int salary {get;}

    public Parent(string name, int age, int salary)
    {
        this.name = name;
        this.age = age;
        this.salary = salary;
    }

    public Parent(Parent parent)
    {
        this.name = parent.name;
        this.age = parent.age;
        this.salary = parent.salary;
    }

    public void Print()
    {
        Console.WriteLine($"{this.name} is {this.age}");
    }
}