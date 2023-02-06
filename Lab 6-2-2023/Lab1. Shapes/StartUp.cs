namespace Lab1._Shapes;

public class Circle : IDrawable
{
    public int Radius { get; set; }

    public Circle(int radius)
    {
        Radius = radius;
    }

    public void Draw()
    {
        double rIn = Radius - 0.4;
        double rOut = Radius + 0.4;
        for (double y = Radius; y >= -Radius; --y)
        {
            for (double x = -Radius; x < rOut; x += 0.5)
            {
                double value = x * x + y * y;
                if (value >= rIn * rIn && value <= rOut * rOut) Console.Write("*");
                else Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

public class Rectangle : IDrawable
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public void Draw()
    {
        DrawLine('*', '*');
        for (int i = 1; i < Height - 1; i++)
        {
            DrawLine('*', ' ');
        }
        DrawLine('*', '*');
    }

    public void DrawLine(char end, char mid)
    {
        Console.Write(end);
        for (int i = 1; i < Width-1; i++)
        {
            Console.Write(mid);
        }

        Console.WriteLine(end); 
    }
}