namespace Lab2._Cars;

public interface ICar
{
    string Model { get; set; }
    string Color { get; set; }
    string Start();
    string Stop();
}