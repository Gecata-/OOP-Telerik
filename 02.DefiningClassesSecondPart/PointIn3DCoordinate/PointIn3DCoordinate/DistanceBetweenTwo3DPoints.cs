//Problem 3. Static class

//  Write a static class with a static method to calculate the distance between two points in the 3D space.
namespace PointIn3DCoordinate
{
    using System;

    public static class DistanceBetweenTwo3DPoints
    {
        public static double Two3DPointsDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = 0;

            distance = Math.Sqrt((firstPoint.pointX - secondPoint.pointX) * (firstPoint.pointX - secondPoint.pointX) +
                                (firstPoint.pointY - secondPoint.pointY) * (firstPoint.pointY - secondPoint.pointY) +
                                (firstPoint.pointZ - secondPoint.pointZ) * (firstPoint.pointZ - secondPoint.pointZ));

            return distance;
        }
    }
}
