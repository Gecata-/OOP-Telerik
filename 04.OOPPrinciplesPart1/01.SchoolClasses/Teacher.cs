namespace SchoolClasses
{
    using System.Collections.Generic;

    public class Teacher : People
    {
        private List<Discipline> setOfDisciplines = new List<Discipline>();

        public Teacher(string name)
        {
            this.Name = name;
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return this.setOfDisciplines;
            }
        }

        public void AddDiscipline(Discipline someDiscipline)
        {
            this.setOfDisciplines.Add(someDiscipline);
        }
    }
}
