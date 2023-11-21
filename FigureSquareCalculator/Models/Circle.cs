using FigureSquareCalculator.Interfaces;

namespace FigureSquareCalculator.Models;

public class Circle : IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentOutOfRangeException("Radius cant have negative value");
        }

        _radius = radius;
    }

    public double GetSquare()
    {
        return Math.PI * _radius * _radius;
    }
}