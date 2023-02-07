using Problem_1._Define_an_Interface_IPerson;
using Problem_6._Food_Shortage;

int N = Convert.ToInt32(Console.ReadLine());
List<Rebel> rebels = new List<Rebel>();
List<Citizen> citizens = new List<Citizen>();
for (int i = 0; i < N; i++)
{
    string[] input = Console.ReadLine().Split();
    if (input.Length == 4)
    {
        var citizen = new Citizen(input[0], int.Parse(input[1]), input[3], input[2]);
        citizens.Add(citizen);
    }
    else
    {
        var rebel = new Rebel(input[0], int.Parse(input[1]), input[2]);
        rebels.Add(rebel);
    }
}
string line;
int food = 0;
while ((line = Console.ReadLine()) != "End")
{
    foreach (var c in citizens)
    {
        if (c.Name == line) food += 10;
    }

    foreach (var r in rebels)
    {
        if (r.Name == line) food += 5;
    }
}

Console.WriteLine("--------------------------------");
Console.WriteLine("Output");
Console.WriteLine("--------------------------------");
Console.WriteLine("Number of Food: " + food);