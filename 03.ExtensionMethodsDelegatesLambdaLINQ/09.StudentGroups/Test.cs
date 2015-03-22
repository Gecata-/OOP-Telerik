//Create a List<Student> with sample students. Select only the students that are from group number 2.
//Use LINQ query. Order the students by FirstName.

namespace StudentGroups
{
    using StudentGroups.Extensions;
    using StudentGroups.MyStudent;

    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Test
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                {new Student("Kolio","Kolev", "123406789","032123456","kondio@abv.bg",new List<double>(),2)},
                {new Student("Vesko","Vishnarov", "987456321","02987456","neshto@yahoo.com",new List<double>(),5)},
                {new Student("Dian","Kirov", "456906123","044654654","email@mail.bg",new List<double>(),2)},
                {new Student("Emanuil","Dobrev", "982563147","02153624","nqkoi@abv.bg",new List<double>(),3)},
                {new Student("Asparuh","Asparuhov", "321654987","032655655","support@abv.bg",new List<double>(),3)},
                {new Student("Tihomir","Tihov", "951706486", "02777777","nomera@nomer.com",new List<double>(),2)},
                {new Student("Petko","Petkov", "125478963","044999888","vis2@abv.bg",new List<double>(),5)}

            };

            var groupTwo = students
                .Where(st => st.GroupNumber == 2)
                .ToArray();

            Console.WriteLine("Ordered by group\n");
            foreach (var student in groupTwo)
            {
                Console.WriteLine(student);
            }

            var firstNameOrdered = students
                .OrderBy(st => st.FirstName);

            Console.WriteLine();
            Console.WriteLine(new string('#', 40));
            Console.WriteLine();

            Console.WriteLine("Ordered by Name\n");
            foreach (var student in firstNameOrdered)
            {
                Console.WriteLine(student);
            }

            var extensionTestByGroup = students.SelectByGroup(2);

            var extensionTestByName = students.OrderByFirstname();

            //Problem 11. Extract students by email

            //Extract all students that have email in abv.bg.
            //Use string methods and LINQ.

            var studentsByEmail = students
                .Where(st => st.Email.Contains("@abv."))
                .ToList();

            Console.WriteLine();
            Console.WriteLine(new string('#', 40));
            Console.WriteLine();

            Console.WriteLine("11. Extract students by email\n");
            foreach (var student in studentsByEmail)
            {
                Console.WriteLine(student);
            }

            //Problem 12. Extract students by phone

            //Extract all students with phones in Sofia.
            //Use LINQ.

            var studentsWithSofiaPhones = students
                .Where(st => st.TelephonNumber.Length == 8 && st.TelephonNumber.Substring(0, 2) == "02")
                .ToList();
            Console.WriteLine();
            Console.WriteLine(new string('#', 40));
            Console.WriteLine();

            Console.WriteLine("12. Extract students by phone\n");
            foreach (var student in studentsWithSofiaPhones)
            {
                Console.WriteLine(student);
            }

            //Problem 13. Extract students by marks

            //Select all students that have at least one mark Excellent (6) 
            //into a new anonymous class that has properties – FullName and Marks.
            //Use LINQ.

            var studentsMarks = new[]
            { 
                new{FullName = "Ivan Dimov", Marks = new[] {6,5,4,6}},
                new{FullName = "Petko Kirov", Marks = new[] {2,3,5,2}},
                new{FullName = "Spas Spasov", Marks = new[] {3,5,4,4}},
                new{FullName = "Ivo Ivov", Marks = new[] {2,5,6,3}},
                new{FullName = "Divopraz Prazkov", Marks = new[] {3,5,4,3}}
            }.ToList();

            var passedStudents = studentsMarks
                .Where(st => st.Marks.Contains(6))
                .ToArray();

            Console.WriteLine();
            Console.WriteLine(new string('#', 40));
            Console.WriteLine();

            Console.WriteLine("13. Extract students by marks\n");
            foreach (var student in passedStudents)
            {
                Console.WriteLine("{0} : {1}", student.FullName, string.Join(", ", student.Marks));
            }
            //Problem 14. Extract students with two marks


            for (int i = 0; i < students.Count; i++)
            {
                students[i].Marks.Add(2);
            }

            for (int i = 0; i < students.Count; i++)
            {
                students[i].Marks.Add(3);
            }

            for (int i = 0; i < students.Count; i++)
            {
                students[i].Marks.Add(6);
            }

            students[0].Marks.Add(2);
            students[2].Marks.Add(2);

            var studentsWithTwoTwo = students.WithTwoMarksPoor();

            Console.WriteLine();
            Console.WriteLine(new string('#', 40));
            Console.WriteLine();

            Console.WriteLine("14. Extract students with two 2 marks\n");
            foreach (var student in studentsWithTwoTwo)
            {
                Console.WriteLine(student);
            }
            //Problem 15. Extract marks

            //Extract all Marks of the students that enrolled in 2006.
            //(The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

            var extractedStudentsMarks = students
                .Where(st => st.FN.Substring(4, 2) == "06")
                .ToArray();

            var studentMarks = extractedStudentsMarks
                .GroupBy(st => st.Marks);

            Console.WriteLine();
            Console.WriteLine(new string('#', 40));
            Console.WriteLine();

            Console.WriteLine("15. Extract marks\n");
            foreach (var mark in studentMarks)
            {
                Console.WriteLine(string.Join(", ", mark.Key));
            }
            //Problem 16.* Groups

            //Create a class Group with properties GroupNumber and DepartmentName.
            //Introduce a property GroupNumber in the Student class.
            //Extract all students from "Mathematics" department.
            //Use the Join operator.

            var mathematicGroup = students
                .Where(st => st.DepartmentName == "Mathematics");

            Console.WriteLine();
            Console.WriteLine(new string('#', 40));
            Console.WriteLine();

            Console.WriteLine("16. Groups\n");
            foreach (var student in mathematicGroup)
            {
                System.Console.Write(string.Join(" | ", student));
            }
            //Problem 18. Grouped by GroupNumber

            //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
            //Use LINQ.

            var studentsByGroupNumber = students
                .GroupBy(st => st.GroupNumber)
                .ToArray();

            Console.WriteLine();
            Console.WriteLine(new string('#', 40));
            Console.WriteLine();

            Console.WriteLine("18.Grouped by GroupNumber\n");
            foreach (var group in studentsByGroupNumber)
            {
                Console.WriteLine("Group {0}\n", group.Key);

                foreach (var student in group)
                {
                    Console.WriteLine(student);
                }
            }

            //Problem 19. Grouped by GroupName extensions

            //Rewrite the previous using extension methods.

            var groupNameExtensions = students.GroupByGroupName();

            Console.WriteLine();
            Console.WriteLine(new string('#', 40));
            Console.WriteLine();

            Console.WriteLine("19.Grouped by GroupName extensions\n");
            foreach (var group in studentsByGroupNumber)
            {
                Console.WriteLine("Group {0}\n", group.Key);

                foreach (var student in group)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}
