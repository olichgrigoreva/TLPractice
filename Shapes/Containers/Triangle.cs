namespace Shapes.Containers;

public class Triangle : IShape
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;
    private readonly double _semiPerimeter;

    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
        _semiPerimeter = (a + b + c) / 2;
    }

    public double CalculateArea()
    {
        var area = Math.Sqrt(_semiPerimeter * (_semiPerimeter - _a) * (_semiPerimeter - _b) * (_semiPerimeter - _c));
        return area;
    }

    public double CalculatePerimeter()
    {
        var perimeter = _a + _b + _c;
        return perimeter;
    }
}