public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    public Point(){}
}

public class Rectangle
{
    public Point TopLeft { get; set; }
    public Point BottomRight { get; set; }

    public Rectangle(Point topLeft, Point bottomRight)
    {
        TopLeft = topLeft;
        BottomRight = bottomRight;
    }

    public bool isInside(Point a)
    {
        return a.X >= BottomRight.X && a.X <= TopLeft.X && a.Y <= BottomRight.Y && a.Y >= TopLeft.Y;
    }

    public static void Main()
    {
        Point topLeft, bottomRight, point;
        Console.WriteLine("Enter top left point");
        string[] input = Console.ReadLine().Split(" ");
        topLeft = new Point(int.Parse(input[0]), int.Parse(input[1]));
        Console.WriteLine("Enter bottom right point");
        string[] input2 = Console.ReadLine().Split(" ");
        bottomRight = new Point(int.Parse(input2[0]), int.Parse(input2[1]));
        Rectangle rect = new Rectangle(topLeft, bottomRight);
        Console.WriteLine("Enter the point to check");
        string[] input3 = Console.ReadLine().Split(" ");
        point = new Point(int.Parse(input3[0]), int.Parse(input3[1]));
        Console.WriteLine(rect.isInside(point));
        
    }
}