//Problem 3. First before last

//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.

namespace FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FirstBeforeLast
    {
        static void Main()
        {

            var studends = new[]
            {
                new{FirstName = "Georgi", LastName ="Petkov", Age = 19},
                new{FirstName = "Stefan", LastName ="Dimov", Age = 29},
                new{FirstName = "Zdravko", LastName ="Blagoev",Age = 20},
                new{FirstName = "Vasko", LastName ="Nikolov",Age = 24},
                new{FirstName = "Avraam", LastName ="Zuev",Age = 23},
                new{FirstName = "Miro", LastName ="Borislavov", Age = 30}
            };

            var firstBeforeLastname = studends
                .Where(st => st.FirstName.CompareTo(st.LastName) < 0)
                .ToArray();

            foreach (var student in firstBeforeLastname)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine(new string('#', 45));
            Console.WriteLine();

            //Problem 4. Age range

            //Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

            var sortedByAge = studends
                .Where(st => st.Age > 18 && st.Age < 24)
                .ToArray();

            foreach (var student in sortedByAge)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            Console.WriteLine();
            Console.WriteLine(new string('#', 45));
            Console.WriteLine();
            //Problem 5. Order students

            //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by
            //first name and last name in descending order.
            //Rewrite the same with LINQ.

            var sortedByDescending = studends
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName)
                .ToArray();

            foreach (var student in sortedByDescending)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            Console.WriteLine();
            Console.WriteLine(new string('#', 45));
            Console.WriteLine();

            var sortedByDescendingWithWords =
                from st in studends
                orderby st.FirstName descending,
                st.LastName descending
                select st;

            foreach (var student in sortedByDescendingWithWords)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }

    }
}
