namespace Problem_1._Person;

public class Person
{
    private string _name;
    private int _age;

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public virtual int Age
    {
        get => _age;
        set => _age = value;
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Person: {Name} is {Age} years old";
    }
}




