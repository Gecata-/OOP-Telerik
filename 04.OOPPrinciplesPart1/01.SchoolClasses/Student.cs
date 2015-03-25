namespace SchoolClasses
{
    public class Student : People
    {
        private readonly int classNumber;


        public Student(string name ,int someClassNUmber)
        {
            this.Name = name;

            this.classNumber = someClassNUmber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
        }

    }
}
