using System;
using FigureAreaLibrary.Interface;

namespace FigureAreaLibrary.Figure
{
    public class Circle : IFigure
    {
        private double _radius;
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius of circle must be a positive value",nameof(radius));
            }

            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
