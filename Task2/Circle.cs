public class Circle : Shape
{
    private int Radius { get; set; } = 20;

    public Circle(string color, int radius) : base(color)
    {
        Radius = radius;
    }

    public Circle()
    {
    }

    public override void GetArea()
    {
        System.Console.WriteLine($"Area Radius: {Radius * Radius * 3.14}");
    }
    public override void GetPerimeter()
    {
        System.Console.WriteLine($"Perimeter Radius: {2 * 3.14 * Radius}");
    }
}