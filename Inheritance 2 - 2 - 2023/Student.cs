namespace Inheritance_2___2___2023;

public class Student:Person
{
    public string SchoolName { get; set; }
    
    public Student(string name, int age, string schoolName) : base(name, age)
    {
        SchoolName = schoolName;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine("Student");
    }
}