namespace SchoolClasses
{
    using System;

    public class TestSchool
    {
        static void Main()
        {
            School telerik = new School("Telerik");

            var classA = new Class('A');
            var classB = new Class('B');

            var math = new Discipline("Math", 36, 72);
            var chemistry = new Discipline("Chemistry", 16, 28);
            var biology = new Discipline("Biology", 36, 100);

            Student studentIvan = new Student("Ivan Ivanov", 123456);
            Student studentPetko = new Student("Petko Ivanov", 987456);
            Student studentHaralampi = new Student("Haralampi Haralampov", 987882);
            Student studentMitko = new Student("Dimitar Haralampov", 143482);
            Student studentDimo = new Student("Dimo Dimov", 437882);
            Student studentStefan = new Student("Stafan Stefanov", 763882);

            var teacherA = new Teacher("Andrei Kostov");
            var teacherP = new Teacher("Petko Asparuhov");

            telerik.AddClass(classA);
            telerik.AddClass(classB);

            classA.AddStudent(studentIvan);
            classA.AddStudent(studentPetko);
            classA.AddStudent(studentHaralampi);
            classB.AddStudent(studentMitko);
            classB.AddStudent(studentDimo);
            classB.AddStudent(studentStefan);

            classA.AddTeacher(teacherA);
            classB.AddTeacher(teacherP);


            teacherA.AddDiscipline(math);
            teacherA.AddDiscipline(chemistry);
            teacherP.AddDiscipline(math);
            teacherP.AddDiscipline(chemistry);
            teacherP.AddDiscipline(biology);

            math.Comment = "Qko matematika";
            teacherA.Comment = "Super daskal";
            teacherP.Comment = "Da se izgoni";
            studentIvan.Comment = "prqkor - Ivan Umnoto";

            Console.WriteLine(telerik);
        }
    }
}
