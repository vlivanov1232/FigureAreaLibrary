using System;
using FigureAreaLibrary.Figure;
using Xunit;

namespace FigureAreaLibrary.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(0,1,1)]
        [InlineData(1,0,1)]
        [InlineData(1,1,0)]
        public void Should_throw_exception_when_side_is_negative(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a,b,c));
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 2, 1)]
        [InlineData(2, 1, 1)]
        public void Should_throw_exception_when_triangle_is_not_exist(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(9.433981, 8, 5)]
        public void Should_be_right_triangle(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.True(triangle.IsRightTriangle());
        }

        [Theory]
        [InlineData(7, 8, 12)]
        public void Should_be_not_right_triangle(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.False(triangle.IsRightTriangle());
        }

        [Theory]
        [InlineData(1, 2, 2, 0.968246)]
        [InlineData(5, 2, 6, 4.683748)]
        public void Should_calculate_valid_area(double a, double b, double c,double expected)
        {
            var triangle = new Triangle(a, b, c);

            var result = triangle.CalculateArea();

            Assert.Equal(expected,result,5);
        }


    }
}
