using FigureSquareCalculator.Models;
using FigureSquareCalculator.Tests.TestCaseSources;
using NUnit.Framework;

namespace FigureSquareCalculator.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(typeof(TriangleTestSource))]
        public void CalculateTriangleSquareTest(Triangle triangle, double expectedSquare)
        {
            double actualSquare = SquareCalculator.CalculateSquare(triangle);
            Assert.AreEqual(expectedSquare, actualSquare, 0.000001);
        }

        [TestCaseSource(typeof(RectangleTestSource))]
        public void CalculateTriangleSquareTest(double a, double b, double c, bool expectedIsRectangle)
        {
            bool actualIsRectangle = new Triangle(a, b, c).IsRectangle;
            Assert.AreEqual(expectedIsRectangle, actualIsRectangle);
        }

        [TestCaseSource(typeof(CircleTestSource))]
        public void CalculateCircleSquareTest(Circle circle, double expectedSquare)
        {
            double actualSquare = SquareCalculator.CalculateSquare(circle);
            Assert.AreEqual(expectedSquare, actualSquare, 0.000001);
        }

        [TestCase(-4)]
        public void WhenCircleRadiusLessThenZeroThenCatchArgumentOutOfRangeExceptionTest(double radius)
        {
            Assert.That(() => new Circle(radius), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(-4,4,3)]
        public void WhenTriangleSideLessThenZeroThenCatchArgumentOutOfRangeExceptionTest(double a, double b, double c)
        {
            Assert.That(() => new Triangle(a,b,c), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(3, 2, 1)]
        public void WhenLargestSideEqualsOrBiggerThanSumOfOtherSidesThenCatchExceptionTest(double a, double b, double c)
        {
            Assert.That(() => new Triangle(a, b, c), Throws.TypeOf<Exception>());
        }
    }
}