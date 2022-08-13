// See https://aka.ms/new-console-template for more information

class Cube : Shape, IShape
{
    public Cube()
    {

    }

    public Cube(double length)
    {
        Length = length;
    }

    public double Length { get; set; }

    public double GetArea()
    {
        return Length * Length;
    }

    public double GetVolume()
    {
        return Math.Pow(Length, 3);
    }
}