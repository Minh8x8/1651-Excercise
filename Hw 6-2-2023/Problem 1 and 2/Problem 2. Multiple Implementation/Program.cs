using Problem_1._Define_an_Interface_IPerson;

string name = Console.ReadLine();
int age = Convert.ToInt32(Console.ReadLine());
string id = Console.ReadLine();
string birthday = Console.ReadLine();
var i = new Citizen(name, age, id, birthday);
Console.WriteLine("--------------------------------");
Console.WriteLine("Output");
Console.WriteLine($"ID: {i.Id}" +
                  $"\nBirthday: {i.BirthDate}");

