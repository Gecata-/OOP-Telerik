namespace SchoolClasses
{
    public class Discipline:School
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExcercises;

        public Discipline(string someName, int someNmberOfLectures, int someNumberOfExcercises)
        {
            this.name = someName;
            this.numberOfLectures = someNmberOfLectures;
            this.numberOfExcercises = someNumberOfExcercises;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExcercises;
            }
        }
    }
}
