namespace Shapes.Containers;

public class Circle : IShape
{
    private readonly double _radius;
    private const double Pi = Math.PI;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double CalculateArea()
    {
        var area = Math.Round(Pi * _radius * _radius);
        return area;
    }

    public double CalculatePerimeter()
    {
        var perimeter = Math.Round(2 * Pi * _radius);
        return perimeter;
    }
}