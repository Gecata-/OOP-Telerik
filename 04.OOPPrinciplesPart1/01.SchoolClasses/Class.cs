
namespace SchoolClasses
{
    using System.Collections.Generic;

    public class Class : School
    {
        private char classIdentifier;

        private List<Teacher> setOfTeachers = new List<Teacher>();

        private List<Student> classStudents = new List<Student>();

        public Class(char a)
        {
            this.classIdentifier = a;
        }

        public char ClassIdentifier
        {
            get
            {
                return this.classIdentifier;
            }
            set
            {
                this.classIdentifier = value;
            }
        }
        public List<Student> ClassStudents
        {
            get
            {
                return this.classStudents;
            }
        }

        public List<Teacher> SetOfTeachers
        {
            get 
            { 
                return this.setOfTeachers;
            }   
        }

        public void AddTeacher(Teacher someTeacher)
        {
            this.setOfTeachers.Add(someTeacher);
        }

        public void AddStudent(Student someStudent)
        {
            this.classStudents.Add(someStudent);
        }
    }
}
