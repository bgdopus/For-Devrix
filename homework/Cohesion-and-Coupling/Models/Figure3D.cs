namespace CohesionAndCoupling.Models
{
    using System;
    using CohesionAndCoupling.Contracts;

    public class Figure3D : Figure, IFigure3D
    {
        private double depth;

        public Figure3D(double width, double height, double depth) : base(width, height)
        {
            this.Depth = depth;
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Depth cannot be zero or a negative number!");
                }

                this.depth = value;
            }
        }
    }
}
