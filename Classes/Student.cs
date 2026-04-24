using System.Security.Cryptography;

namespace ConsoleApp2;

class Student {
    public string name;
    public string age;
    public string grade;

    public Student(string name, string age, string grade) {
        this.name = name;
        this.age = age;
        this.grade = grade;
    }

    public void Display() {
        Console.WriteLine($"{name}: {age}, {grade}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[5];
        for (int i = 0; i < 5; ++i) {
            Console.WriteLine("Enter student name");
            string name  = new string(Console.ReadLine());
            Console.WriteLine("Enter student age");
            string age = new string(Console.ReadLine());
            Console.WriteLine("Enter student grade");
            string grade = new string(Console.ReadLine());
            students[i] = new Student(name, age, grade);
        }        

        foreach (Student student in students) {
            student.Display();
        }
    }
}
