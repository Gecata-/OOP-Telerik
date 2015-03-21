//Create a List<Student> with sample students. Select only the students that are from group number 2.
//Use LINQ query. Order the students by FirstName.

namespace StudentGroups
{
    using StudentGroups.Extensions;
    using StudentGroups.MyStudent;

    using System.Collections.Generic;
    using System.Linq;

    class Test
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                {new Student("Kolio","Kolev", 123456789,"032123456","kondio@abv.bg",2)},
                {new Student("Vesko","Vishnarov", 987456321,"02987456","neshto@yahoo.com",5)},
                {new Student("Dian","Kirov", 456987123,"044654654","email@mail.bg",2)},
                {new Student("Emanuil","Dobrev", 982563147,"02153624","nqkoi@abv.bg",3)},
                {new Student("Asparuh","Asparuhov", 321654987,"032655655","support@abv.bg",3)},
                {new Student("Tihomir","Tihov", 951732486, "02777777","nomera@nomer.com",2)},
                {new Student("Petko","Petkov", 125478963,"044999888","vis2@abv.bg",5)}

            };

            var groupTwo = students
                .Where(st => st.GroupNumber == 2)
                .ToArray();

            var firstNameOrdered = students
                .OrderBy(st => st.FirstName);

            var extensionTestByGroup = students.SelectByGroup(2);

            var extensionTestByName = students.OrderByFirstname();

            //Problem 11. Extract students by email

            //Extract all students that have email in abv.bg.
            //Use string methods and LINQ.

            var studentsByEmail = students
                .Where(st => st.Email.Contains("@abv."))
                .ToList();

            //Problem 12. Extract students by phone

            //Extract all students with phones in Sofia.
            //Use LINQ.

            var studentsWithSofiaPhones = students
                .Where(st => st.TelephonNumber.Length == 8 && st.TelephonNumber.Substring(0, 2) == "02")
                .ToList();

            //Problem 13. Extract students by marks

            //Select all students that have at least one mark Excellent (6) 
            //into a new anonymous class that has properties – FullName and Marks.
            //Use LINQ.

            var studentsMarks = new[]
            { 
                new{FullName = "Ivan Dimov", Marks = new[] {6,5,4,6},},
                new{FullName = "Petko Kirov", Marks = new[] {2,3,5,2}},
                new{FullName = "Spas Spasov", Marks = new[] {3,5,4,4}},
                new{FullName = "Ivo Ivov", Marks = new[] {2,5,6,3}},
                new{FullName = "Divopraz Prazkov", Marks = new[] {3,5,4,3}}
            }.ToList();

            var passedStudents = studentsMarks
                .Where(st => st.Marks.Contains(6))
                .ToArray();

           //var studentsWithTwoPoor = studentsMarks
           //    .FindAll(st => st.Marks.)
               
        }
    }
}
