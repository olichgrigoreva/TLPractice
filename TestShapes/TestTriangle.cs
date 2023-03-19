using Shapes.Containers;

namespace TestShapes;

public class TestTriangle
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestArea()
    {
        //arrange
        var triangle = new Triangle(3, 3, 4);
        //act
        var triangleArea = Math.Round(triangle.CalculateArea());
        //assert
        Assert.That(triangleArea, Is.EqualTo(4), "Triangle area doesn't valid");
    }

    [Test]
    public void TestPerimeter()
    {
        //arrange
        var triangle = new Triangle(3, 3, 4);
        //act
        var trianglePerimeter = Math.Round(triangle.CalculatePerimeter());
        //assert
        Assert.That(trianglePerimeter, Is.EqualTo(10), "Triangle perimeter doesn't valid");
    }
}