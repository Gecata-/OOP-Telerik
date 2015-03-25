namespace SchoolClasses
{
    public class People:School
    {
        private string name;

        public People()
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }
}
