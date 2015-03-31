namespace StudentClass
{
    using StudentClass;

    using System;
    using System.Collections.Generic;

    class StudentTest
    {
        static void Main()
        {
            var students = new List<Student> 
            {
                {new Student("Petko Ivanov Draganov",189753624,"Plovdiv Aliosha","0888999999","aliosha@abv.bg",4,Specialty.Informatics,University.UHT,Faculty.Technological)},
                {new Student("Radko Arnaudov Dimov",123456789,"Sofia","0888123456","sofia@abv.bg",5,Specialty.Chemistry,University.UNSS,Faculty.Technical)},
                {new Student("Petko Ivanov Draganov",189753624,"Plovdiv Aliosha","0888999999","aliosha@abv.bg",4,Specialty.Informatics,University.UHT,Faculty.Technological)},
                {new Student("Stafan stefkov Valdobrev",987321645,"Kazanlak Kapana","0877786412","armeec@abv.bg",4,Specialty.Biotehnology,University.PU,Faculty.Technical)}
            };

            Console.WriteLine(students[0].Equals(students[2])); //true
            Console.WriteLine(students[0].Equals(students[3])); //false 

            Console.WriteLine(students[0]);

            Console.WriteLine("Hash Code: {0}",students[0].GetHashCode());

            Console.WriteLine(students[0] == students[2]);
            Console.WriteLine(students[0] == students[3]);

            var someStudent = new Student("Radko Arnaudov Dimov", 123456789, "Sofia", "0888123456", "sofia@abv.bg", 5, Specialty.Chemistry, University.UNSS, Faculty.Technical);

            var copiedStudent = (Student)someStudent.Clone();

            Console.WriteLine();
            Console.WriteLine(someStudent);
            Console.WriteLine();
            Console.WriteLine(copiedStudent);
            Console.WriteLine();

            copiedStudent.Email = "BaiIvan@abv.bg";
            copiedStudent.MobilePhone = "0899000000";
            

            Console.WriteLine();
            Console.WriteLine(someStudent);
            Console.WriteLine();
            Console.WriteLine(copiedStudent);
            Console.WriteLine();


            var studentForCompare = new Student("Petko Ivanov Draganov", 189753629, "Plovdiv Aliosha", "0888999999", "aliosha@abv.bg", 4, Specialty.Informatics, University.UHT, Faculty.Technological);

            if (studentForCompare.CompareTo(students[0])>0)
            {
                Console.WriteLine("StudentForCompare is first");
            }
            else
            {
                Console.WriteLine("student[0] is first");
            }
        }
    }
}
