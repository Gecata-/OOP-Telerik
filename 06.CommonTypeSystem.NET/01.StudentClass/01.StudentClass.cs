//  Problem 1. Student class

//  Define a class Student, which contains data about a student 
//  – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. 
//  Use an enumeration for the specialties, universities and faculties.
//  Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

namespace StudentClass
{
    using System;

    public class Student: ICloneable,IComparable
    {
        private string firstName;
        private string midleName;
        private string lastName;
        private int sSN;
        private string permamentAdress;
        private string mobilePhone;
        private string eMail;
        private int course;
        private Specialty speciality;
        private University university;
        private Faculty faculty;


#region 
        public Student()
        {
        }

        public Student(string threeNames, int studentSerialNumber, string somePermamentAdress, string someMobilePhone, string someEMail, int someCourse,
            Specialty someSpeciality, University someUniversity, Faculty someFaculty)
        {
            string[] names = threeNames.Split(' ');
            this.firstName = names[0];
            this.midleName = names[1];
            this.lastName = names[2];
            this.sSN = studentSerialNumber;
            this.permamentAdress = somePermamentAdress;
            this.mobilePhone = someMobilePhone;
            this.eMail = someEMail;
            this.course = someCourse;
            this.speciality = someSpeciality;
            this.university = someUniversity;
            this.faculty = someFaculty;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException();
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.midleName;
            }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException();
                }
                this.midleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException();
                }
                this.lastName = value;
            }
        }

        public int SSN
        {
            get
            {
                return this.sSN;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("SSN must be positive number.");
                }
                this.sSN = value;
            }
        }

        public string PermamentAdress
        {
            get
            {
                return this.permamentAdress;
            }
            set
            {
                this.permamentAdress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.eMail;
            }
            set
            {
                this.eMail = value;
            }
        }

        public int Course
        {
            get
            {
                return this.course;
            }
            private set
            {
                this.course = value;
            }
        }

        public Specialty Speciality
        {
            get
            {
                return this.speciality;
            }

            private set
            {
                this.speciality = value;
            }
        }

        public University University
        {
            get
            {
                return this.university;
            }
            private set
            {
                this.university = value;
            }
        }

        public Faculty Faculty
        {
            get
            {
                return this.faculty;
            }
            private set
            {
                this.faculty = value;
            }
        }

        public override bool Equals(object obj)
        {
            var student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (student.SSN != this.SSN)
            {
                return false;
            }

            return true;
        }
        public override string ToString()
        {
            return string.Format("First name: {0} \nMiddle name: {1} \nLast name: {2} \nSSN: {3} \nAdress {4} \nMObile phone: {5} \nE-mail: {6} \nCourse: {7} \nSpeciality: {8} \nUniversity: {9} \nFaculty: {10}",
                this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermamentAdress, this.MobilePhone, this.Email, this.Course, this.Speciality.ToString(), this.University.ToString(), this.Faculty.ToString());
        }

        public override int GetHashCode()
        {
            return this.PermamentAdress.GetHashCode() ^ this.SSN.GetHashCode();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(Student.Equals(firstStudent, secondStudent));
        }

#endregion

        //  Problem 2. IClonable

        //  Add implementations of the ICloneable interface. 
        //  The Clone() method should deeply copy all object's fields into a new object of type Student.

        public object Clone()
        {
            var newStudent = new Student();

            newStudent.FirstName = (string)this.FirstName.Clone();
            newStudent.MiddleName = (string)this.MiddleName.Clone();
            newStudent.LastName = (string)this.LastName.Clone();
            newStudent.SSN = this.SSN;
            newStudent.PermamentAdress = (string)this.PermamentAdress.Clone();
            newStudent.MobilePhone = (string)this.MobilePhone.Clone();
            newStudent.Email = (string)this.Email.Clone();
            newStudent.Course = this.Course;
            newStudent.Speciality = this.Speciality;
            newStudent.University = this.University;
            newStudent.Faculty = this.Faculty;

            return newStudent;
        }

        //  Problem 3. IComparable

        //  Implement the IComparable<Student> interface to compare students by names 
        //  (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).


        public int CompareTo(object obj)
        {
            var someStudent = obj as Student;

            if (this.firstName.CompareTo(someStudent.FirstName) != 0)
            {
                return this.firstName.CompareTo(someStudent.FirstName);
            }

            if (this.MiddleName.CompareTo(someStudent.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(someStudent.MiddleName);
            }

            if (this.LastName.CompareTo(someStudent.LastName) != 0)
            {
                return this.LastName.CompareTo(someStudent);
            }

            if (this.SSN.CompareTo(someStudent.SSN) != 0)
            {
                return this.SSN.CompareTo(someStudent.SSN);
            }

            return 0;
        }
    }
}
