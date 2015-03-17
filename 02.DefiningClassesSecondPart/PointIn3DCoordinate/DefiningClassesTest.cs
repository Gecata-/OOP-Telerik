
namespace DefiningClassesSecondPart
{
    using System;

    using PointIn3DCoordinate;
    using GenericClass;
    using Matrix;

    [DefiningClassesSecondPart.VersionAttribute.Version("1.01")]

    class DefiningClassesTest
    {
        public static void Main()
        {
            //PointIn3DCoordinate

            Point3D first = new Point3D(3, 2, 4);
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

            //GenericClass

            GenericList<string> genericList = new GenericList<string>();

            for (int i = 0; i < 10; i++)
            {
                genericList.Add("BMW");
            }

            genericList.Insert(5, "MERCEDES");

            genericList[6] = "Ferrari";

            for (int i = 0; i < 4; i++)
            {
                genericList.Add("BMW");
            }

            genericList.Add("a");

            Console.WriteLine(genericList[7]);
            Console.WriteLine(genericList[5]);
            Console.WriteLine(genericList[6]);

            Console.WriteLine(genericList.Count);
            Console.WriteLine(genericList.Capacity);
            Console.WriteLine(genericList);

            Console.WriteLine(genericList.Max());
            Console.WriteLine(genericList.Min());

            genericList.ClearList();

            Console.WriteLine("| {0} | ", genericList[6]);

            // Matrix

            Matrix<int> firstMatrix = new Matrix<int>(2, 3);

            int count = 0;

            for (int i = 0; i < firstMatrix.GetRowLength; i++)
            {
                for (int j = 0; j < firstMatrix.GetColLength; j++)
                {
                    firstMatrix[i, j] = ++count;
                }

            }

            Matrix<int> secondMatrix = new Matrix<int>(3, 2);

            for (int i = 0; i < secondMatrix.GetRowLength; i++)
            {
                for (int j = 0; j < secondMatrix.GetColLength; j++)
                {
                    secondMatrix[i, j] = ++count;
                }

            }

            Matrix<int> multiplyResult = firstMatrix * secondMatrix;

            Matrix<int> test1 = new Matrix<int>(3, 3);
            Matrix<int> test2 = new Matrix<int>(3, 3);

            int secontCount = 1;

            for (int i = 0; i < test1.GetRowLength; i++)
            {
                for (int j = 0; j < test1.GetColLength; j++)
                {
                    test1[i, j] = secontCount++;
                }

            }

            secontCount = 1;

            for (int i = 0; i < test2.GetRowLength; i++)
            {
                for (int j = 0; j < test2.GetColLength; j++)
                {
                    test2[i, j] = secontCount;
                }

            }

            Matrix<int> additionResult = test1 + test2;

            Matrix<int> subtractionResult = test1 - test2;

            bool nonZero = additionResult ? true : false;
            Console.WriteLine(nonZero);

            Console.WriteLine(multiplyResult);
            Console.WriteLine(additionResult);
            Console.WriteLine(subtractionResult);

            //VersionAttribute

            Type type = typeof(DefiningClassesTest);

            var attributes = type.GetCustomAttributes(false);

            foreach (DefiningClassesSecondPart.VersionAttribute.Version item in attributes)
            {
                Console.WriteLine("[Version {0:}.{1:D2}]", item.major,item.minor);
            }
        }

    }
}
