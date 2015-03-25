//  Problem 1. School classes

//  We are given a school. In the school there are classes of students. Each class has a set of teachers. 
//  Each teacher teaches a set of disciplines. Students have name and unique class number. 
//  Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. 
//  Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
//  Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, define the 
//  class hierarchy and create a class diagram with Visual Studio.
namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        private string comment;
        private string schoolName;

        private List<Class> classes = new List<Class>();

        public School()
        {
        }

        public School(string name)
        {
            this.schoolName = name;
        }


        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public void AddClass(Class someClass)
        {
            this.classes.Add(someClass);
        }


        public override string ToString()
        {
            var sb = new StringBuilder();


            sb.Append(string.Format("School: {0}", schoolName));

            foreach (var someClass in this.classes)
            {
                var classTeachers = someClass.SetOfTeachers;


                sb.Append(string.Format("\nClasses: {0}\n", string.Join(", ", someClass.ClassIdentifier)));


                foreach (var item in classTeachers)
                {
                    sb.Append(string.Format("\nTeacher: {0}"
                        , item.Name.ToString()));

                    var disciplines = item.Disciplines;

                    foreach (var discipline in disciplines)
                    {
                        sb.Append(string.Format("\nDisciplines: {0}", string.Join(", ", discipline.Name)));
                    }
                }
            
                var clssStudents = someClass.ClassStudents;
                foreach (var item in clssStudents)
                {
                    sb.Append(string.Format("\nStudents: {0} ", string.Join(", ", item.Name)));
                    sb.Append(string.Format("\nNumber: {0} ", string.Join(", ", item.ClassNumber.ToString())));
                }
            }

            return sb.ToString();
        }
    }
}
