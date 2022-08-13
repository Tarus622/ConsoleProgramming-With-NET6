
class Triangle : Shape, IShape
{
    public Triangle()
    {

    }

    public Triangle(double height ,double length)
    {
        Height = height;
        Length = length;
    }

    public double Hypotenuese { get; set; }
    public double Height { get; set; }
    public double Length { get; set; }

    public double GetArea()
    {
        return (Length * Height) / 2;
    }
}