using Shapes.Containers;

namespace TestShapes;

public class TestSquare
{
    [Test]
    public void TestArea()
    {
        //arrange
        var square = new Square(3);
        //act
        var squareArea = Math.Round(square.CalculateArea());
        //assert
        Assert.That(squareArea, Is.EqualTo(9), "Square area doesn't valid");
    }

    [Test]
    public void TestPerimeter()
    {
        //arrange
        var square = new Square(4);
        //act
        var squarePerimeter = Math.Round(square.CalculatePerimeter());
        //assert
        Assert.That(squarePerimeter, Is.EqualTo(16), "Square perimeter doesn't valid");
    }
}