using Problem_1._Define_an_Interface_IPerson;
using Problem_4._Border_Control;

string line;
List<Object> obj = new List<Object>();
List<string> idList = new List<string>();
while ((line=Console.ReadLine()) != "End")
{
    string[] input = line.Trim().Split();
    if (input.Length == 3)
    {
        var citizen = new Citizen(input[0], int.Parse(input[1]), input[2]);
        obj.Add(citizen);
        idList.Add(citizen.Id);
    }
    else
    {
        var robot = new Robot(input[0], input[1]);
        obj.Add(robot);
        idList.Add(robot.Id);
    }
}
var idFake = Console.ReadLine();

Console.WriteLine("--------------------------------");
Console.WriteLine("Checking ID Fake");
Console.WriteLine("--------------------------------");
foreach (var id in idList)
{
    string lastThreeId = id.Substring(id.Length - 3);
    if (idFake == lastThreeId) Console.WriteLine("ID Fake:" + id);
}
