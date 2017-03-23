namespace Abstraction
{
    using System;
    using Abstraction.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            // Circle tests
            double radius = 5;
            ICircle circle = new Circle(radius);
            Console.WriteLine(
                "I am a circle. " +
                "My perimeter is {0:f2}. My surface is {1:f2}.",
                circle.CalcPerimeter(), 
                circle.CalcSurface());

            // Rectangle tests
            double width = 2;
            double height = 3;
            IRectangle rect = new Rectangle(width, height);
            Console.WriteLine(
                "I am a rectangle. " +
                "My perimeter is {0:f2}. My surface is {1:f2}.",
                rect.CalcPerimeter(), 
                rect.CalcSurface());
        }
    }
}
