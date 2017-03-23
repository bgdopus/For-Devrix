namespace CohesionAndCoupling.Utils
{
    using System;
    using CohesionAndCoupling.Models;

    public class FigureCalculator
    {
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        public static double CalcDiagonal2D(IFigure figure)
        {
            double distance = CalcDistance2D(0, 0, figure.Width, figure.Height);
            return distance;
        }
    }
}
