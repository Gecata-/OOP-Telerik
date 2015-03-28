namespace Shapes
{
    public class Triangle:Shape
    {
        public Triangle(double someHeight, double someWidth)
        {
            this.Height = someHeight;
            this.Width = someWidth;
        }

        public override double CalculateSurface()
        {
            double surface = (this.Height * this.Width) / 2;

            return surface;
        }
    }
}
