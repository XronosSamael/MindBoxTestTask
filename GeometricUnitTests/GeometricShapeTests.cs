using MindBoxTestTask;
using MindBoxTestTask.Shapes;
using NUnit.Framework;

namespace GeometricUnitTests;

/// <summary>
/// Юнит-тесты для геометрических фигур
/// </summary>
[TestFixture]
public class GeometricShapeTests
{
    /// <summary>
    /// Тестируем правильность вычисления площади треугольника
    /// </summary>
    [Test]
    [TestCase(3, 4, 5, 6)]
    [TestCase(6, 8, 10, 24)]
    public void TriangleSquareTest(double firstSide, double secondSide, double thirdSide, double area)
    {
        GeometricShape shape = new Triangle(firstSide, secondSide, thirdSide);

        Assert.That(shape.Area, Is.EqualTo(area));
    }
    
    /// <summary>
    /// Тестируем правильность вычисления площади круга
    /// </summary>
    [Test]
    [TestCase(5, Math.PI * 25)]
    [TestCase(10, Math.PI * 100)]
    public void CircleSquareTest(double radius, double area)
    {
        GeometricShape shape = new Circle(radius);

        Assert.That(shape.Area, Is.EqualTo(area));
    }
}