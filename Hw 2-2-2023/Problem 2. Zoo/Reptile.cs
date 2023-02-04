namespace Problem_2._Zoo;

public class Reptile : Animal
{
    public Reptile(string name) : base(name)
    {
    }
    public override string ToString()
    {
        return $"{"Reptile",-10} {Name}";
    }
}

public class Lizard : Reptile
{
    public Lizard(string name) : base(name)
    {
    }
    public override string ToString()
    {
        return $"{"Lizard",-10} {Name}";
    }
}

public class Snake : Reptile
{
    public Snake(string name) : base(name)
    {
    }
    public override string ToString()
    {
        return $"{"Snake",-10} {Name}";
    }
}