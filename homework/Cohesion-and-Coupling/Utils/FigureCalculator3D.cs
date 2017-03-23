namespace CohesionAndCoupling.Utils
{
    using System;
    using Contracts;

    public class FigureCalculator3D
    {
        public static double CalculateDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double powerXDistance = (x2 - x1) * (x2 - x1);
            double powerYDistance = (y2 - y1) * (y2 - y1);
            double powerZDistance = (z2 - z1) * (z2 - z1);

            double distance = Math.Sqrt(powerXDistance + powerYDistance + powerZDistance);
            return distance;
        }

        public static double CalculateVolume(IFigure3D figure)
        {
            double volume = figure.Width * figure.Height * figure.Depth;
            return volume;
        }

        public static double CalculateDiagonal3D(IFigure3D figure)
        {
            double distance = CalculateDistance3D(0, 0, 0, figure.Width, figure.Height, figure.Depth);
            return distance;
        }
    }
}