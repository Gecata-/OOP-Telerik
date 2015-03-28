//  Problem 1. Shapes

//  Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//  Define two new classes Triangle and Rectangle that implement the virtual method and return the 
//  surface of the figure (heightwidth for rectangle and heightwidth/2 for triangle).

namespace Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get 
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Width must be more than 0.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Height must be more than 0.");
                }

                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
