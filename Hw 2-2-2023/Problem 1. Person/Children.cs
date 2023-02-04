namespace Problem_1._Person;

public class Children : Person
{
    public override int Age
    {
        get => base.Age;
        set => base.Age = value > 15 ? throw new Exception("Age cannot be greater than 15") : value;

    }

    public Children(string name, int age) : base(name, age)
    {
    }

    public override string ToString()
    {
        return $"Children: {Name} is {Age} years old";
    }
}

