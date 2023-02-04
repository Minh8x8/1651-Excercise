namespace Problem_3._Players_and_Monster;

public class Hero
{
    public string UserName { get; set; }
    public int Level { get; set; }

    public Hero(string userName, int level)
    {
        UserName = userName;
        Level = level;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name,-15} {this.UserName,-25} {this.Level}";
    }
}

public class Elf : Hero
{
    public Elf(string userName, int level) : base(userName, level)
    {
    }
}

public class MuseElf : Elf
{
    public MuseElf(string userName, int level) : base(userName, level)
    {
    }
}

public class Wizard : Hero
{
    public Wizard(string userName, int level) : base(userName, level)
    {
    }
}

public class DarkWizard : Wizard
{
    public DarkWizard(string userName, int level) : base(userName, level)
    {
    }
}

public class SoulMaster : DarkWizard
{
    public SoulMaster(string userName, int level) : base(userName, level)
    {
    }
}

public class Knight : Hero
{
    public Knight(string userName, int level) : base(userName, level)
    {
    }
}

public class DarkKnight : Knight
{
    public DarkKnight(string userName, int level) : base(userName, level)
    {
    }
}

public class BladeKnight : DarkKnight
{
    public BladeKnight(string userName, int level) : base(userName, level)
    {
    }
}