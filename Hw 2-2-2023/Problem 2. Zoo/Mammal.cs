namespace Problem_2._Zoo;

public class Mammal : Animal
{
    public Mammal(string name) : base(name)
    {
    }
    public override string ToString()
    {
        return $"{"Mammal",-10} {Name}";
    }
}

public class Gorilla : Mammal
{
    public Gorilla(string name) : base(name)
    {
    }
    public override string ToString()
    {
        return $"{"Gorilla",-10} {Name}";
    }
}

public class Bear : Gorilla
{
    public Bear(string name) : base(name)
    {
    }
    public override string ToString()
    {
        return $"{"Bear",-10} {Name}";
    }
}