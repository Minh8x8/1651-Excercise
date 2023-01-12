class Rhombus
{
    public static void PrintRow(int stars, int size)
    {
        for (int i = 0; i < size - stars; i++)
        {
            Console.Write(" ");
        }

        for (int i = 1; i < stars; i++)
        {
            Console.Write("*");
            Console.Write(" ");
        }
        Console.WriteLine("*");
    }

    public static void Main()
    {
        Console.WriteLine("Enter the size of Rhombus of stars:");
        int size = int.Parse(Console.ReadLine());
        for (int i = 1; i <= size; i++)
        {
            PrintRow(i, size);
        }

        for (int i = size - 1; i >= 1; i--)
        {
            PrintRow(i, size);
        }
    }
}