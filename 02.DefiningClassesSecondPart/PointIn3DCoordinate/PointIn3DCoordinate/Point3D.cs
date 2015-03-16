//Problem 1. Structure

//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
//Implement the ToString() to enable printing a 3D point.

//Problem 2. Static read-only field

//Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
//Add a static property to return the point O.
namespace DefiningClassesSecondPart.PointIn3DCoordinate
{
    public struct Point3D
    {
        private static readonly Point3D pointZero = new Point3D(0, 0, 0);

        public double pointX;
        public double pointY;
        public double pointZ;

        public Point3D(double somePointX, double somePointY, double somePointZ)
        {
            this.pointX = somePointX;
            this.pointY = somePointY;
            this.pointZ = somePointZ;
        }

        public static Point3D PointZero
        {
            get
            {
                return pointZero;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.pointX, this.pointY, this.pointZ);
        }
    }
}





