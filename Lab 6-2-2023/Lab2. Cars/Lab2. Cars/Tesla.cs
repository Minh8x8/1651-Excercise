namespace Lab2._Cars;

public class Tesla : ICar, IElectricCar
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int Battery { get; set; }

    public Tesla(string model, string color, int battery)
    {
        Model = model;
        Color = color;
        Battery = battery;
    }

    public string Start() => "Engine start";

    public string Stop() => "Breaaak!";
    public override string ToString() => $"{Color} {Model} Model with {Battery} batteries" +
                                         $"\n{Start()}" +
                                         $"\n{Stop()}";
}