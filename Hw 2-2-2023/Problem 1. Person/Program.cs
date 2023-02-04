namespace Problem_1._Person;

internal static class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person("Minh", 20);
        Console.WriteLine(person.ToString());
        Children children = new Children("Nhan", 1);
        Console.WriteLine(children.ToString());
    }
}