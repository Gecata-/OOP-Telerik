//Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() 
//that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.

namespace StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, int someWeekSalary, int someWorkHoursPerDay)
            : base(firstName, lastName)
        {
            this.weekSalary = someWeekSalary;
            this.workHoursPerDay = someWorkHoursPerDay;
        }

        public int WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Sallary must be equal or more than 0.");
                }

                this.weekSalary = value;

            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Work ours per day must be equal or more than 0.");
                }

                this.workHoursPerDay = value;

            }
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = this.weekSalary / this.workHoursPerDay;

            return moneyPerHour;
        }

        public override string ToString()
        {
            return string.Format("Worker \nFirst name: {0} \nLast name: {1} \nWeek salary: {2} \nWork hours per day: {3}\n"
                , this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}
