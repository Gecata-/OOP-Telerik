//Problem 6. Divisible by 7 and 3

//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
namespace DivisibleBy7And3
{
    using System;
    using System.Linq;

    class DivisibleBy7And3
    {
        static void Main()
        {
            var arrOfInts = new int[50];

            for (int i = 0; i < arrOfInts.Length; i++)
            {
                arrOfInts[i] = i;
            }

            var sevenAndThreeDevisible = arrOfInts
                .Where(x => x % 7 == 0 || x % 3 == 0)
                .ToArray();

            foreach (var number in sevenAndThreeDevisible)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            var sevenAndThreeDevisibleWithKeyWords =
                from x in arrOfInts
                where x % 3 == 0 || x % 7 == 0
                select x;

            foreach (var number in sevenAndThreeDevisibleWithKeyWords)
            {
                Console.WriteLine(number);
            }
        }
    }
}
