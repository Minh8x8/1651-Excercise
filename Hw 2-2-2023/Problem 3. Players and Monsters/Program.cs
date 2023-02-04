// See https://aka.ms/new-console-template for more information

using Problem_3._Players_and_Monster;

Console.WriteLine($"{"Type", -15} {"UserName", -25} {"Level", -15}");
var elf = new Elf("Elf", 20);
var heroList = new List<Hero>();
heroList.Add(new Hero("Victim", 100));
heroList.Add(new Elf("Aura Bella Fiora", 100));
heroList.Add(new MuseElf("Mare Bello Fiore", 100));
heroList.Add(new Wizard("Momonga", 100));
heroList.Add(new DarkWizard("Ainz Ooal Gown", 100));
heroList.Add(new SoulMaster("Wish III", 100));
heroList.Add(new Knight("Shalltear Bloodfallen", 100));
heroList.Add(new DarkKnight("Demiugre", 100));
heroList.Add(new BladeKnight("Gargantua", 100));

foreach (var hero in heroList)
{
    Console.WriteLine(hero.ToString());
}