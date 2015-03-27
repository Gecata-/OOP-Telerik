namespace AnimalHierarchy
{
    public class Kitten : Cat
    {

        public Kitten(string someName, int someAge)
            : base(someName, someAge)
        {
            this.Gender = Gender.Female;
        }
    }
}
