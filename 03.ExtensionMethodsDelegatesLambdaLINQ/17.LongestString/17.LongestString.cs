//Problem 17. Longest string

//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.

namespace LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LongestString
    {
        static void Main()
        {
            List<string> arrStrings = new List<string> { "abv", "Kondio", "Mersi", "zaek", "Helikopter" };

            var longestString = arrStrings
                .OrderByDescending(s => s.Length)
                .First();

            Console.WriteLine(longestString);
        }
    }
}
