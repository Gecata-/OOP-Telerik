//Define new class Student which is derived from Human and has new field – grade. 

namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastNmae, int someGrade)
            : base(firstName, lastNmae)
        {
            this.grade = someGrade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 1 && value > 12)
                {
                    throw new ArgumentOutOfRangeException("Grade must be more or equal to 1, and fewer than 12.");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Student \nFirst name: {0} \nLast name: {1} \nGrade: {2}\n", this.FirstName, this.LastName, this.Grade);
        }
    }
}
