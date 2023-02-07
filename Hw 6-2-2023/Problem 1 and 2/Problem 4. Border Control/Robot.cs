namespace Problem_4._Border_Control;

public class Robot
{
    public string Model { get; set; }
    public string Id { get; set; }

    public Robot(string model, string id)
    {
        Model = model;
        Id = id;
    }
}