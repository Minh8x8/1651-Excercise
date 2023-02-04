namespace Problem_4._Need_forSpeed;

public class Vehicle
{
    public int HorsePower { get; set; }
    public double Fuel { get; set; }
    public double DefaultFuelConsumption = 1.25;
    public virtual double FuelConsumption()

    public Vehicle(int horsePower, double fuel)
    {
        HorsePower = horsePower;
        Fuel = fuel;
    }
    
}