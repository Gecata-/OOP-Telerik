//Problem 10. Student groups extensions

//Implement the previous using the same query expressed with extension methods.

namespace StudentGroups.Extensions
{
    using StudentGroups.MyStudent;
    using System.Collections.Generic;

    using System.Linq;

    public static class StudentGroupsExtensions
    {
        public static List<Student> SelectByGroup(this List<Student> students, int group)
        {
            var result = new List<Student>();

            foreach (var item in students)
            {
                if (item.GroupNumber == group)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static List<Student> OrderByFirstname(this List<Student> students)
        {
            List<Student> result = students
                .OrderBy(st => st.FirstName)
                .ToList();

            return result;
        }

        //Problem 14. Extract students with two marks

        //Write down a similar program that extracts the students with exactly two marks "2".
        //Use extension methods.

        public static List<Student> WithTwoMarksPoor(this List<Student> someStudents)
        {
            int z = 0;
            var result = new List<Student>();

            for (int i = 0; i < someStudents.Count; i++)
            {
                var student = someStudents[i];
                z = 0;
                for (int j = 0; j < student.Marks.Count; j++)
                {                   
                    if (student.Marks[j] == 2)
                    {
                        z++;
                    }

                }
                if (z == 2)
                {
                    result.Add(student);
                }
                
            }
            return result;
        }

        public static dynamic GroupByGroupName(this List<Student> someStudents)
        {
            var studentsByGroupNumber = someStudents
                .GroupBy(st => st.GroupNumber)
                .ToList();

            return studentsByGroupNumber;
        }
    }
}
