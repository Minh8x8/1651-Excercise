namespace Problem_4._Need_for_Speed;

public class Vehicle
{
    public static double DefaultFuelConsumption = 1.25;
    public virtual double FuelConsumption { get; set; } = DefaultFuelConsumption;
    public double Fuel { get; set; }    
    public int HorsePower { get; set; }

    public Vehicle(double fuel, int horsePower)
    {
        Fuel = fuel;
        HorsePower = horsePower;
    }

    public virtual void Drive(double km)
    {
        if (Fuel >= FuelConsumption * km)
        {
            Fuel -= FuelConsumption * km;
            Console.WriteLine($"{this.GetType().Name} is driven {km} kilometers");
        }
        else Console.WriteLine($"{this.GetType().Name} does not have enough fuel to drive");
    }

    public override string ToString() => $"{this.GetType().Name,-20} {HorsePower,-10}";
}

public class Motorcycle : Vehicle
{
    public new static double DefaultFuelConsumption = 1.5;
    public override double FuelConsumption { get; set; } = DefaultFuelConsumption;

    public Motorcycle(double fuel, int horsePower) : base(fuel, horsePower)
    {
    }
}

public class RaceMotorcycle : Motorcycle
{
    public new static double DefaultFuelConsumption = 8;
    public override double FuelConsumption { get; set; } = DefaultFuelConsumption;
    public RaceMotorcycle(double fuel, int horsePower) : base(fuel, horsePower)
    {
    }
}

public class CrossMotorcycle : Motorcycle
{
    public CrossMotorcycle(double fuel, int horsePower) : base(fuel, horsePower)
    {
    }
}

public class Car : Vehicle
{
    public new static double DefaultFuelConsumption = 3;
    public override double FuelConsumption { get; set; } = DefaultFuelConsumption;
    public Car(double fuel, int horsePower) : base(fuel, horsePower)
    {
    }
}

public class FamilyCar : Car
{
    public FamilyCar(double fuel, int horsePower) : base(fuel, horsePower)
    {
    }
}

public class SportCar : Car
{
    public new static double DefaultFuelConsumption = 10;
    public override double FuelConsumption { get; set; } = DefaultFuelConsumption;
    public SportCar(double fuel, int horsePower) : base(fuel, horsePower)
    {
    }
}
