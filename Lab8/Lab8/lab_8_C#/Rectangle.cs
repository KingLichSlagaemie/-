
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X},{Y})";
    }
}

public struct Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Point Position { get; set; }

    public Rectangle(Point position, int width, int height)
    {
        Position = position;
        Width = width;
        Height = height;
    }
 
    public int CalculateArea()
    {
        return Width * Height;
    }
    public int CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }

    public bool ContainsPoint(Point point)
    {
        return point.X >= Position.X &&
               point.X <= Position.X + Width &&
               point.Y >= Position.Y &&
               point.Y <= Position.Y + Height;
    }

    public override string ToString()
    {
        return $"Прямоугольник: позиция {Position}, ширина {Width}, высота {Height}";
    }
}

