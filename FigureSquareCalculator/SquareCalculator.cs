using FigureSquareCalculator.Interfaces;

namespace FigureSquareCalculator
{
    public static class SquareCalculator
    {
        public static double CalculateSquare<T>(T shape) where T : IFigure
        {
            return shape.GetSquare();
        }
    }
}