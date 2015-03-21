//Problem 9. Student groups

//Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
//Create a List<Student> with sample students. Select only the students that are from group number 2.
//Use LINQ query. Order the students by FirstName.

namespace StudentGroups.MyStudent
{
    using System.Collections.Generic;

    public class Student
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly int facultetNumber;
        private string telephonNumber;
        private string email;
        private List<double> marks;
        private int groupNumber;

        public Student(string someFirstName, string someLastdName, int someFacultetNumber,
            string someTelephoneNumber, string someEmail, int someGroupNumber)
        {
            this.firstName = someFirstName;
            this.lastName = someLastdName;
            this.facultetNumber = someFacultetNumber;
            this.telephonNumber = someTelephoneNumber;
            this.email = someEmail;
            this.groupNumber = someGroupNumber;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string Lastname
        {
            get
            {
                return this.lastName;
            }
        }

        public int FN
        {
            get 
            {
                return this.facultetNumber;
            }
        }

        public string TelephonNumber
        {
            get
            {
                return this.telephonNumber;
            }
            set
            {
                this.telephonNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public List<double> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
               this.marks.Add((dynamic)value);
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                this.groupNumber = value;
            }
        }
    }
}
