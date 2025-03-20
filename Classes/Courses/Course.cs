namespace Class;

public class Course
{
    public string name { get; private set; }
    public int month { get; private set; }
    public Module[] module { get; private set; }

    public Course(string name, int month, Module[] module)
    {
        this.name = name;
        this.month = month;
        this.module = module;
    }

    public Course(Course course)
    {
        this.name = course.name;
        this.month = course.month;
        this.module = course.module;
    }
}