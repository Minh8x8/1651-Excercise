// See https://aka.ms/new-console-template for more information

using Problem_4._Need_for_Speed;

var vehicle = new Vehicle(100, 1000);
vehicle.Drive(5);
var motorcycle = new Motorcycle(100, 222);
motorcycle.Drive(10);

Console.WriteLine($"{"Type", -20} {"HorsePower", -10}");
Console.WriteLine(vehicle.ToString());
Console.WriteLine(motorcycle.ToString());