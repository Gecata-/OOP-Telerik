//  Write a program that tests the behaviour of the CalculateSurface() method for 
//  different shapes (Square, Rectangle, Triangle) stored in an array.

namespace ShapeTest
{
    using Shapes;

    using System;
    using System.Collections.Generic;

    class ShapeTest
    {
        static void Main()
        {
            var shapes = new List<Shape> 
            {
                {new Square(5)},
                {new Square(4.7)},
                {new Rectangle(5,5)},
                {new Triangle(4,4)},
                {new Rectangle(7.94,8.54)},
                {new Triangle(8,9.24)}
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape: {0} \nSurface Area: {1}", shape.GetType().Name, shape.CalculateSurface());
                Console.WriteLine(new string('-',25));
            }
        }
    }
}
