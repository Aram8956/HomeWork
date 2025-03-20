namespace Class;

public class Group
{
    public string name{get; private set;}
    public int quantity{get; private set;}
    public Course course{get; private set;}

    public Group(string name, int quantity, Course course)
    {
        this.name = name;
        this.quantity = quantity;
        this.course = course;
    }
}