namespace Abstraction.Contracts
{
    internal interface ICircle
    {
        double Radius { get; set; }

        double CalcPerimeter();

        double CalcSurface();
    }
}
