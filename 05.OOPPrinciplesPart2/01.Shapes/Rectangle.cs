namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double someHeight, double someWidth)
        {
            this.Height = someHeight;
            this.Width = someWidth;
        }

        public override double CalculateSurface()
        {
            double surface = this.Height * this.Width;

            return surface;
        }
    }
}
