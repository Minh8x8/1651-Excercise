// See https://aka.ms/new-console-template for more information

using Problem_2._Zoo;

Console.WriteLine($"{"Type", -10} Name");

List<Animal> zoo = new List<Animal>();
zoo.Add(new Animal("Golden fish"));
zoo.Add(new Reptile("Komodo dragon"));
zoo.Add(new Lizard("Chameleon"));
zoo.Add(new Snake("King cobra"));
zoo.Add(new Mammal("Chihuahua"));
zoo.Add(new Gorilla("Mountain gorilla"));
zoo.Add(new Bear("Brown bear"));

foreach (var animal in zoo)
{
    Console.WriteLine(animal.ToString());
}
