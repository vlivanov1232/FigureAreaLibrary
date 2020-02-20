using System;
using FigureAreaLibrary.Interface;

namespace FigureAreaLibrary.Figure
{
    public class Triangle : IFigure
    {

        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        private const double Tolerance = 0.00001;

        public Triangle(double sideA, double sideB, double sideC)
        {
            CheckIsValidTriangle(sideA, sideB, sideC);
            
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        public double CalculateArea()
        {
            return GetAreaByHeronFormula(_sideA, _sideB, _sideC);
        }

        public bool IsRightTriangle()
        {
            return Math.Abs(Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) - Math.Pow(_sideC, 2)) < Tolerance ||
                   Math.Abs(Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2) - Math.Pow(_sideA, 2)) < Tolerance ||
                   Math.Abs(Math.Pow(_sideC, 2) + Math.Pow(_sideA, 2) - Math.Pow(_sideB, 2)) < Tolerance;
        }

        private void CheckIsValidTriangle(in double sideA, in double sideB, in double sideC)
        {
            if (sideA < 0)
            {
                throw new ArgumentException("Side of triangle must be a positive value", nameof(sideA));
            }

            if (sideB < 0)
            {
                throw new ArgumentException("Side of triangle must be a positive value", nameof(sideB));
            }

            if (sideC < 0)
            {
                throw new ArgumentException("Side of triangle must be a positive value",nameof(sideC));
            }

            CheckIsExistingTriangle(sideA, sideB, sideC);
        }

        private void CheckIsExistingTriangle(in double sideA, in double sideB, in double sideC)
        {
            if (!(sideA + sideB > sideC && sideA + sideC > sideB && sideC + sideB > sideA))
            {
                throw new ArgumentException($"Triangle with sides {sideA} , {sideB} , {sideC} cannot exist.");
            }
        }

        private double GetAreaByHeronFormula(in double sideA, in double sideB, in double sideC)
        {
            var hP = GetHalfPerimeter(_sideA, _sideB, _sideC);
            return Math.Sqrt(hP * (hP - _sideA) * (hP - _sideB) * (hP - _sideC));
        }

        private double GetHalfPerimeter(in double sideA, in double sideB, in double sideC)
        {
            return (sideA + sideB + sideC) / 2;
        }
    }
}
