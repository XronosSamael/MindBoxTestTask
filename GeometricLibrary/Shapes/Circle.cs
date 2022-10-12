namespace MindBoxTestTask.Shapes;

/// <summary>
/// Круг
/// </summary>
public sealed class Circle : GeometricShape
{
    private readonly double _radius;
    
    /// <summary>
    /// Создает экземпляр круга
    /// </summary>
    /// <param name="radius">Радиус круга</param>
    public Circle(double radius)
    {
        _radius = radius;
    }

    /// <inheritdoc/>
    public override double Area => Math.PI * Math.Pow(_radius, 2);
}