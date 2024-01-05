public class Rectangle : Shape
{
    private int Width { get; set; } = 12;
    private int Length { get; set; } = 10;

    public Rectangle(string color, int width, int length) : base(color)
    {
        Width = width;
        Length = length;
    }
    public override void GetArea()
    {
        System.Console.WriteLine($"Area Rectangle: {Width * Length}");
    }
    public override void GetPerimeter()
    {
        System.Console.WriteLine($"Perimeter Rectangle: {(Width + Length) * 2}");
    }
    public Rectangle() { }

}