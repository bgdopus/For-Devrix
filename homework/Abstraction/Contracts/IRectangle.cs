namespace Abstraction.Contracts
{
    internal interface IRectangle
    {
        double Width { get; set; }

        double Height { get; set; }

        double CalcPerimeter();

        double CalcSurface();
    }
}
