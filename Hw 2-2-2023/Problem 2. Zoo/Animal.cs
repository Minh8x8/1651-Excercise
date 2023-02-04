namespace Problem_2._Zoo;

public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"{"Animal",-10} {Name}";
    }
}