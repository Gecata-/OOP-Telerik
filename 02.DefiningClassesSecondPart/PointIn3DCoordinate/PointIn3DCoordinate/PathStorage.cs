//Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.
namespace DefiningClassesSecondPart.PointIn3DCoordinate
{
    using System.IO;

    public static class PathStorage
    {

        public static void Write(Point3D some3DPoint)
        {

            StreamReader streamReader = new StreamReader(@"..\..\Points3D.txt");
            string points;

            using (streamReader)
            {
                points = streamReader.ReadToEnd();
            }

            StreamWriter streamWriter = new StreamWriter(@"..\..\Points3D.txt");
            using (streamWriter)
            {
                streamWriter.Write(points);
                streamWriter.WriteLine("{0}, {1}, {2}", some3DPoint.pointX, some3DPoint.pointY, some3DPoint.pointZ);
            }
        }

        public static Path<Point3D> Read()
        {
            StreamReader streamReader = new StreamReader(@"..\..\Points3D.txt");
            Point3D point3D = new Point3D();
            Path<Point3D> arrayOfPoints = new Path<Point3D>();


            string somePoint = streamReader.ReadLine();

            while (somePoint != null)
            {
                string[] points = somePoint.Split(',');

                point3D.pointX = double.Parse(points[0].Trim());
                point3D.pointY = double.Parse(points[1].Trim());
                point3D.pointZ = double.Parse(points[2].Trim());

                arrayOfPoints.Add(point3D);

                somePoint = streamReader.ReadLine();
            }
            streamReader.Close();

            return arrayOfPoints;
        }
    }
}
