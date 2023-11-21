using FigureSquareCalculator.Interfaces;

namespace FigureSquareCalculator.Models;

public class Triangle : IFigure
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;
    public bool IsRectangle { get; private set; }

    public Triangle(double a, double b, double c)
    {
        if (a < 0 || b < 0 || c < 0)
        {
            throw new ArgumentOutOfRangeException("Side cant have negative value");
        }
        double max = Math.Max(Math.Max(a, b), c);
        if (max >= a + b + c - max)
        {
            throw new Exception("It is impossible to create a triangle with these sides");
        }

        _a = a;
        _b = b;
        _c = c;

        IsRectangle = CheckForRectangle();
    }

    public double GetSquare()
    {
        double p = (_a + _b + _c) / 2;

        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }

    private bool CheckForRectangle()
    {
        double max = Math.Max(Math.Max(_a, _b), _c);
        return Math.Abs(max * max - (_a * _a + _b * _b + _c * _c - max * max)) < 0.000001;
    }
}