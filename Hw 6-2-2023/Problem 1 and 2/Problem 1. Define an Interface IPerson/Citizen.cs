using Problem_2._Multiple_Implementation;

namespace Problem_1._Define_an_Interface_IPerson;

public class Citizen : IPerson, IBirthable, IIdentifiable
{
    public Citizen(string name, int age, string birthDate, string id)
    {
        Name = name;
        Age = age;
        BirthDate = birthDate;
        Id = id;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string BirthDate { get; set; }
    public string Id { get; set; }

    public Citizen(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Citizen(string name, int age, string id)
    {
        Name = name;
        Age = age;
        Id = id;
    }
}