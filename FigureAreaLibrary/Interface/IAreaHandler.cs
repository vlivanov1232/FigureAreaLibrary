namespace FigureAreaLibrary.Interface
{
    public interface IAreaHandler
    {
        double GetArea(IFigure figure);

        double GetCircleArea(double radius);

        double GetTriangleArea(double sideA, double sideB, double sideC);

        bool CheckIsRightTriangle(double sideA, double sideB, double sideC);
    }
}