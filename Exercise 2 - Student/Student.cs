namespace Exercise_2___Student;

public class Student
{
    private int _age;
    private double _gpa;
    private string _name;

    public int Age
    {
        get => _age;
        set
        {
            if (value <= 0 || value >= 150) throw new Exception("Invalid age");
            _age = value;
        }
    }

    public double Gpa
    {
        get => _gpa;
        set
        {
            if (value < 0 || value >4) throw new Exception("Invalid gpa");
            _gpa = value;
        }
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Student(string name, int age, double gpa)
    {
        Age = age;
        Gpa = gpa;
        Name = name;
    }

    public Student()
    {
        
    }

    public void DisplayInformation()
    {
        Console.WriteLine($"Student Name: {_name}" +
                          $"\nAge: {_age}" +
                          $"\nGpa: {_gpa}");
    }

    static void Main()
    {
        Student s1 = new Student();
        s1.Name = "Minh";
        s1.Age = 10;
        s1.Gpa = 3.4;
        s1.DisplayInformation();
        Student s2 = new Student("Kiet", 18, 3.3);
        s2.DisplayInformation();
    }
}