//Problem 3. Animal hierarchy

//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
//Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
//Kittens and tomcats are cats. All animals are described by age, name and sex. 
//Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

namespace AnimalHierarchy
{
    using System;

    using System.Collections.Generic;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;

        public Animal(string someName, int someAge)
        {
            this.name = someName;
            this.age = someAge;
        }

        public Animal(string someName, int someAge, Gender sex)
        {
            this.name = someName;
            this.age = someAge;
            this.Gender = sex;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can`t be empty");
                }

                this.name = value;
            }
        }

        public int Age 
        {
            get
            {
                return this.age;
            }           
        }

        public Gender Gender { get; protected set; }

        public abstract void MakeSound();

        public static double AverageAge(IEnumerable<Animal> animals)
        {
            double average = 0;
            double sum = 0;
            int count = 0;

            foreach (var animal in animals)
            {
                sum += animal.Age;
                count++;
            }

            average = sum / count;

            return average;
        }
    }
}
