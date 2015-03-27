//Problem 2. Students and workers

//Define abstract class Human with first name and last name. 
//Define new class Student which is derived from Human and has new field – grade. 
//Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() 
//that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

namespace StudentsAndWorkers
{
    using System;

    public abstract class Human 
    {
        private string firstName;
        private string lastName;

        public Human(string someFirstName, string someLastname)
        {
            this.firstName = someFirstName;
            this.lastName = someLastname;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name, must not ve empty");
                }
                if (value.Length<2)
                {
                    throw new ArgumentOutOfRangeException("Name must be more than 1 symbol");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name, must not ve empty");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Name must be more than 1 symbol");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Human \nFirst name: {0} \nLast name: {1}\n", this.FirstName, this.LastName);
        }
    }
}
