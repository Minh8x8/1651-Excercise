namespace Problem_6._Animals;

public class Animal
{
    public string Name
    {
        get; set;
    }
    public int Age { get; set; }
    public string Gender { get; set; }

    public Animal(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public virtual string ProduceSound() => "Animal sounds";

    public override string ToString() => $"{GetType().Name}" +
                                         $"\n{Name} {Age} {Gender}" +
                                         $"\n{ProduceSound()}";
}

public class Dog : Animal
{
    public Dog(string name, int age, string gender) : base(name, age, gender)
    {
    }

    public override string ProduceSound() => "Woof!";
}

public class Cat : Animal
{
    public Cat(string name, int age, string gender) : base(name, age, gender)
    {
    }

    public override string ProduceSound() => "Meow meow";
}

public class Frog : Animal
{
    public Frog(string name, int age, string gender) : base(name, age, gender)
    {
    }
    public override string ProduceSound() => "Ribbit";
}

public class Kitten : Cat
{
    public Kitten(string name, int age) : base(name, age, "Female")
    {
    }

    public override string ProduceSound() => "Meow";
}

public class Tomcat : Cat
{
    public Tomcat(string name, int age) : base(name, age, "Male")
    {
    }

    public override string ProduceSound() => "MEOW";
}