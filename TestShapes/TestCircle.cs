using Shapes.Containers;

namespace TestShapes;

public class TestCircle
{
    [Test]
    public void TestArea()
    {
        //arrange
        var circle = new Circle(5);
        //act
        var circleArea = circle.CalculateArea();
        //assert
        Assert.That(circleArea, Is.EqualTo(79), "Circle area doesn't valid");
    }

    [Test]
    public void TestPerimeter()
    {
        //arrange
        var circle = new Circle(5);
        //act
        var circlePerimeter = circle.CalculatePerimeter();
        //assert
        Assert.That(circlePerimeter, Is.EqualTo(31), "Circle perimeter doesn't valid");
    }
}