namespace Lab2._Cars;

public class Seat : ICar
{
    public string Model { get; set; }
    public string Color { get; set; }

    public Seat(string model, string color)
    {
        Model = model;
        Color = color;
    }

    public string Start() => "Engine start";

    public string Stop() => "Breaaak!";

    public override string ToString() => $"{Color} {this.GetType().Name} {Model}" +
                                         $"\n{Start()}" +
                                         $"\n{Stop()}";
}