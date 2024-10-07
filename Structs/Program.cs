var rectangle = new Rectangle(200, 300);
var immutableRectangle = new ImmutableRectangle(200, 300);

public struct Rectangle
{
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Width { get; set; }
    public double Height { get; set; }
}

public readonly struct ImmutableRectangle
{
    public ImmutableRectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Width { get; init; }
    public double Height { get; init; }
}