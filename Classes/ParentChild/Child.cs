namespace ParentChild;

public class Child
{
    public string name {get;}
    public int age {get;}
    public Parent parent1 {get;}
    public Parent parent2 {get;}

    public Child(string name, int age, Parent parent1, Parent parent2)
    {
        this.name = name;
        this.age = age;
        this.parent1 = new Parent(parent1);
        this.parent2 = new Parent(parent2);
    }

    public Child(Child child)
    {
        this.name = child.name;
        this.age = child.age;
        this.parent1 = child.parent1;
        this.parent2 = child.parent2;
    }

    public int AgeSum()
    {
        return parent1.age + parent2.age;
    }

    public void Print()
    {
        Console.Write($"{this.name} is {this.age} years old. Parents:");
        parent1.Print();
        parent2.Print();
    }
}