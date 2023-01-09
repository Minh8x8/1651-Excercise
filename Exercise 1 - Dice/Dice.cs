public class Dice
{
    private int _side;

    public int Side
    {
        get { return _side;}
        set
        {
            if (value > 3)
            {
                _side = value;
            }
            else throw new Exception("Sides cannot be less than 4");
        }
    }
    
    public Dice(int side, string type)
    {
        Side = side;
        Type = type;
    }
    public Dice() {}
    public string Type { get; set; }
    public int Roll()
    {
        Random random = new Random();
        return random.Next(1, _side +1);
    }

}