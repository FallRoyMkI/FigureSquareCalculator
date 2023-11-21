using System.Collections;
using FigureSquareCalculator.Models;

namespace FigureSquareCalculator.Tests.TestCaseSources;

public class RectangleTestSource : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        double a = 5;
        double b = 3;
        double c = 4;
        bool isRectangle = true;
        yield return new object[] { a, b, c, isRectangle };

        a = 1;
        b = 1;
        c = 1;
        isRectangle = false;
        yield return new object[] { a, b, c, isRectangle };
    }
}