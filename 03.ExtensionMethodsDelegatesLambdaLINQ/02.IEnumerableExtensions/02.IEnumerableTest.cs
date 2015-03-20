namespace MyIEnumerable
{
    using System;
    using System.Collections.Generic;

    using MyIEnumerable.Extensions;

    class IEnumerable
    {
        static void Main()
        {
            var listOfNumbers = new List<double> { 1.5, 1.5, 2.5, 2.5, 10, 100 };

            var sum = listOfNumbers.Sum();
            Console.WriteLine(sum);

            var product = listOfNumbers.Product();
            Console.WriteLine(product);

            var min = listOfNumbers.Min();
            Console.WriteLine(min);

            var max = listOfNumbers.Max();
            Console.WriteLine(max);

            var average = listOfNumbers.Average();
            Console.WriteLine(average);
        }
    }
}
