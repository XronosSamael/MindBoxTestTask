namespace MindBoxTestTask.Shapes;

/// <summary>
/// Треугольник
/// </summary>
public sealed class Triangle : GeometricShape
{
    private readonly double _firstSide;
    private readonly double _secondSide;
    private readonly double _thirdSide;
    private readonly double _halfPerimeter;

    /// <summary>
    /// Создает экземпляр треугольника
    /// </summary>
    /// <param name="firstSide">Первая сторона</param>
    /// <param name="secondSide">Вторая сторона</param>
    /// <param name="thirdSide">Третья сторона</param>
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
        _halfPerimeter = (_firstSide + _secondSide + _thirdSide) * 0.5;
    }

    /// <inheritdoc/>
    public override double Area => Math.Sqrt(_halfPerimeter * (_halfPerimeter - _firstSide)
                                                        * (_halfPerimeter - _secondSide)
                                                        * (_halfPerimeter - _thirdSide));

    /// <summary>
    /// Является ли треугольник прямоугольным
    /// </summary>
    public bool IsRectangular =>
        (Math.Abs(Math.Pow(_firstSide, 2) - Math.Pow(_secondSide, 2) - Math.Pow(_thirdSide, 2)) < double.Epsilon)
        || (Math.Abs(Math.Pow(_secondSide, 2) - Math.Pow(_firstSide, 2) - Math.Pow(_thirdSide, 2)) < double.Epsilon)
        || (Math.Abs(Math.Pow(_thirdSide, 2) - Math.Pow(_firstSide, 2) - Math.Pow(_secondSide, 2)) < double.Epsilon);
}