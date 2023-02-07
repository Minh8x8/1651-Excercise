namespace Problem_5._Birthday;

public class Pet
{
    public string Name {get; set; }
    public string BirthDate {get; set; }

    public Pet(string name, string birthDate)
    {
        Name = name;
        BirthDate = birthDate;
    }
}