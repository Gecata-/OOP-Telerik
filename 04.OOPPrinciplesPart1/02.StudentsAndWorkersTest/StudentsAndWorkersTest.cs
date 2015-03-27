namespace StudentsAndWorkersTest
{
    using StudentsAndWorkers;

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class StudentsAndWorkersTest
    {
        static void Main()
        {
            //Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).

            var students = new List<Student>
            {

              {new Student("Petko", "Petkov", 1)},
              {new Student("Ivan", "Ivanov", 2)},
              {new Student("Dimo", "Petkov", 3)},
              {new Student("Arni", "Arnaudov", 4)},
              {new Student("Mirko", "MIrkov", 5)},
              {new Student("Hasan", "Hasanov", 6)},
              {new Student("Stefan", "Stefkov", 7)},
              {new Student("Tihomr", "MIrov", 8)},
              {new Student("Atanas", "Petkov", 9)},
              {new Student("Stoqn", "Dimitrov", 10)}

            };

            var studentOrderedByGrade = students
                .OrderBy(st => st.Grade)
                .ToList();
            Console.WriteLine();
            Console.WriteLine("############# Students ##################");
            Console.WriteLine();

            foreach (var student in studentOrderedByGrade)
            {
                Console.WriteLine(student);
                
            }

            //Initialize a list of 10 workers and sort them by money per hour in descending order.

            var workers = new List<Worker>
            {

              {new Worker("Petko", "Dimo",150,8)},
              {new Worker("Ivan", "Petkov", 250,12)},
              {new Worker("Dimo", "Petkov", 350,6)},
              {new Worker("Arni", "Hasanov", 450,12)},
              {new Worker("Mirko", "MIrkov", 550,5)},
              {new Worker("Hasan", "Hasanov", 650,9)},
              {new Worker("Stefan", "Ivan", 750,4)},
              {new Worker("Tihomr", "Hasan", 850,4)},
              {new Worker("Atanas", "Petkov", 950,6)},
              {new Worker("Stoqn", "Mirko", 1050,12)}

            };

            var workersSortedByMoneyPerHour = workers
                .OrderBy(w => w.MoneyPerHour())
                .ToArray();

            Console.WriteLine();
            Console.WriteLine("############# Workers ##################");
            Console.WriteLine();

            foreach (var worker in workersSortedByMoneyPerHour)
            {
                Console.WriteLine("{0}Money per hour: {1}\n",worker ,worker.MoneyPerHour());
            }

            //Merge the lists and sort them by first name and last name.

            var humans = new List<Human>(students.Count + workers.Count);

            humans.AddRange(students);
            humans.AddRange(workers);

            var sortedByNameHumans = humans
                .OrderBy(h => h.FirstName)
                .ThenBy(h => h.LastName)
                .ToArray();

            Console.WriteLine();
            Console.WriteLine("############# Humans ##################");
            Console.WriteLine();

            foreach (var human in sortedByNameHumans)
            {
                Console.WriteLine(human);
            }
        }
    }
}
