using System;
using FigureAreaLibrary.Figure;
using FigureAreaLibrary.Interface;

namespace FigureAreaLibrary
{
    class FigureArea : IAreaHandler
    {
        public double GetArea(IFigure figure)
        {
            return figure?.CalculateArea() ?? throw new ArgumentNullException(nameof(figure));
        }

        public double GetCircleArea(double radius)
        {
            return new Circle(radius).CalculateArea();
        }

        public double GetTriangleArea(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA,sideB,sideC).CalculateArea();
        }

        public bool CheckIsRightTriangle(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC).IsRightTriangle();
        }
    }
}
