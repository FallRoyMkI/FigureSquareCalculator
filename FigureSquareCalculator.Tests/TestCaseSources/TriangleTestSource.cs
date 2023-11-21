using System.Collections;
using FigureSquareCalculator.Models;

namespace FigureSquareCalculator.Tests.TestCaseSources;

public class TriangleTestSource : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        Triangle triangle = new(5, 3, 4);
        double square = 6;
        yield return new object[] { triangle, square };

        triangle = new(5, 4, 5);
        square = 9.165151;
        yield return new object[] { triangle, square };

        triangle = new(3, 3, 3);
        square = 3.897114;
        yield return new object[] { triangle, square };

        triangle = new(3.5, 5.2, 4.3);
        square = 7.467931;
        yield return new object[] { triangle, square };
    }
}
