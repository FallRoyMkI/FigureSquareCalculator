using System.Collections;
using FigureSquareCalculator.Models;

namespace FigureSquareCalculator.Tests.TestCaseSources;

public class CircleTestSource : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        Circle circle = new(1);
        double square = 3.141592;
        yield return new object[] { circle, square };

        circle = new(5);
        square = 78.539816;
        yield return new object[] { circle, square };

        circle = new(3.0015);
        square = 28.302615;
        yield return new object[] { circle, square };
    }
}