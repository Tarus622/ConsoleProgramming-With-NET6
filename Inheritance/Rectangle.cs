
class Rectangle : Shape, IShape
{
    public Rectangle()
    {

    }

    public Rectangle(double width, double length)
    {
        Width = width;
        Length = length;
    }

    public double Width { get; set; }
    public double Length { get; set; }
    public double GetArea()
    {
        return Length * Width;
    }
}