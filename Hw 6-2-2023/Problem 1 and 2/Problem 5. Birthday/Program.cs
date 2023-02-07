using System.Globalization;
using Problem_1._Define_an_Interface_IPerson;

string line;
var dateList = new List<DateTime>();
while ((line = Console.ReadLine()) != "End")
{
    string[] lineParts = line.Split(" ");
    if (lineParts[0] != "Robot")
    {
        string birthday = lineParts[lineParts.Length - 1];
            DateTime date = 
                DateTime.ParseExact(birthday, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        dateList.Add(date);
    }
}

int yearInput = int.Parse(Console.ReadLine());
int countEmpty = 0;

Console.WriteLine("---------------------------------");
Console.WriteLine("Output");
Console.WriteLine("--------------------------------");
foreach (var date in dateList)
{
    if (date.Year == yearInput)
    {
        Console.WriteLine(date.ToString("dd/MM/yyyy"));
        countEmpty++;
    }
    
}
if (countEmpty == 0) Console.WriteLine("<empty output>");