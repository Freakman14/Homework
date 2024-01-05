public class Shape
{
    private string Color { get; set; }

    public Shape(string color)
    {
        Color = color;
    }
    public string GetColor()
    {
        return $"{Color}";
    }
    public virtual void GetArea() { }
    public virtual void GetPerimeter(){}

    public Shape()
    {
    }
}