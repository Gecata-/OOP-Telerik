//Problem 9. Student groups

//Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
//Create a List<Student> with sample students. Select only the students that are from group number 2.
//Use LINQ query. Order the students by FirstName.

namespace StudentGroups.MyStudent
{
    using StudentGroups.MyGroup;

    using System.Collections.Generic;

    public class Student
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly string facultetNumber;
        private string telephonNumber;
        private string email;
        private List<double> marks;
        private Group studentGroup;

        public readonly Group Mathematics = new Group(2, "Mathematics");
        public readonly Group Biology = new Group(3, "Biology");
        public readonly Group Chemistry = new Group(5, "Chemistry");

        public Student(string someFirstName, string someLastdName, string someFacultetNumber,
            string someTelephoneNumber, string someEmail, List<double> someMarks, int someGroupNumber)
        {
            this.firstName = someFirstName;
            this.lastName = someLastdName;
            this.facultetNumber = someFacultetNumber;
            this.telephonNumber = someTelephoneNumber;
            this.email = someEmail;
            this.marks = someMarks;     

            if (someGroupNumber == 2)
            {
                this.studentGroup = Mathematics;
            }

            if (someGroupNumber == 3)
            {
                this.studentGroup = Biology;
            }

            if (someGroupNumber == 5)
            {
                this.studentGroup = Chemistry;
            }
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

        public string FN
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
                return this.studentGroup.GroupNumber;
            }
            set
            {
                this.studentGroup.GroupNumber = value;
            }
        }

        public string DepartmentName
        {
            get
            {
                return this.studentGroup.DepartmentName;
            }
        }

        public override string ToString()
        {
            return string.Format("First Name: {0} \nLast Name: {1} \nFacultet Number: {2} \nTelephon Number: {3} \nEmail: {4} \nMarks: {5} \nGroup Number: {6} \nDepartment Name: {7}\n"
                , this.firstName, this.lastName, 
                this.facultetNumber, this.telephonNumber,
                this.email, string.Join(" ,", marks), 
                this.studentGroup.GroupNumber, this.studentGroup.DepartmentName);
        }
    }
}
