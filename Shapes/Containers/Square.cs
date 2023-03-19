namespace Shapes.Containers;

public class Square : IShape
{
    private readonly double _length;

    public Square(double length)
    {
        _length = length;
    }

    public double CalculateArea()
    {
        var area = _length * _length;
        return area;
    }

    public double CalculatePerimeter()
    {
        var perimeter = 4 * _length;
        return perimeter;
    }
}