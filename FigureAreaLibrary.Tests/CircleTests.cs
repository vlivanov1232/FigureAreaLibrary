using System;
using FigureAreaLibrary.Figure;
using Xunit;

namespace FigureAreaLibrary.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(-5)]

        public void Should_throw_exception_when_radius_is_negative(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Theory]
        [InlineData(5, 78.539816)]
        [InlineData(12, 452.389342)]

        public void Should_calculate_area(double radius,double expected)
        {
            var circle = new Circle(radius);

            var result = circle.CalculateArea();

            Assert.Equal(expected, result, 5);
        }
    }


}
