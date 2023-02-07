using Problem_1._Define_an_Interface_IPerson;

namespace Problem_6._Food_Shortage;

public class Rebel : IPerson
{
    public Rebel(string name, int age, string group)
    {
        Name = name;
        Age = age;
        Group = group;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Group { get; set; }
    
    
}