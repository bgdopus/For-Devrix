namespace CohesionAndCoupling.Contracts
{
    using CohesionAndCoupling.Models;

    public interface IFigure3D : IFigure
    {
        double Depth { get; set; }
    }
}
