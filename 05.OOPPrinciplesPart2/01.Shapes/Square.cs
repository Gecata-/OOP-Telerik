//  Define class Square and suitable constructor so that at initialization height must be kept equal to 
//  width and implement the CalculateSurface() method.
namespace Shapes
{
    using System;

    public class Square : Shape
    {
        public Square(double side)
        {
            this.Height = side;
            this.Width = side;
        }

        public override double CalculateSurface()
        {
            double surface = this.Height * this.Height;

            return surface;
        }
    }
}
