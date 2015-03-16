
namespace PointIn3DCoordinate
{
    class PointIn3DCoordinateTest
    {
        public static void Main()
        {
            Point3D first = new Point3D(3,2,4);
            Point3D second = new Point3D(5, 12, 14);
            Point3D third = new Point3D(8, 15, 14);

            Path<Point3D> arr = new Path<Point3D>();

            arr.Add(first);
            arr.Add(second);
            arr.Add(third);


            double result = DistanceBetweenTwo3DPoints.Two3DPointsDistance(first, second);


            System.Console.WriteLine(result);

            PathStorage.Write(second);
            PathStorage.Write(first);
            PathStorage.Write(third);


            Path<Point3D> test = PathStorage.Read();

            for (int i = 0; i < test.Count; i++)
            {
                System.Console.WriteLine(test[i]);
            }

        }

    }
}
