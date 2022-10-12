using MindBoxTestTask.Shapes;
using NUnit.Framework;

namespace GeometricUnitTests;

/// <summary>
/// Юнит-тесты для треугольника
/// </summary>
[TestFixture]
public class TriangleTests
{
    /// <summary>
    /// Проверяем правильность определения того, что треугольник прямоугольный
    /// </summary>
    [Test]
    [TestCase(3, 4, 5, true)]
    [TestCase(1, 1, 2, false)]
    [TestCase(1, 6, 20, false)]
    [TestCase(9, 12, 15, true)]
    public void CheckTriangleIsRectangularTest(double firstSide, double secondSide, double thirdSide, bool isRectangular)
    {
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        
        Assert.That(triangle.IsRectangular, Is.EqualTo(isRectangular));
    }
}