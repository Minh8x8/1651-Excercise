public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public virtual void Print()
    {
        Console.WriteLine($"{Name} is {Age} years old");
    }
}
