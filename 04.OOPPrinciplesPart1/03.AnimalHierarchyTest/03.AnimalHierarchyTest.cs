//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

namespace AnimalHierarchyTest
{
    using AnimalHierarchy;

    using System;
    using System.Linq;

    class AnimalHierarchyTest
    {
        static void Main()
        {
            var animals = new Animal[]
            {
                new Dog("Karamanka",4,Gender.Female),
                new Kitten("Mimi", 3),
                new Tomcat("Cezar",3),
                new Frog("Jabcho",7,Gender.Male),
                new Tomcat("Tom", 7),
                new Frog("Stefka",8,Gender.Female),
                new Kitten("Suzi", 5),
                new Dog("Rex",6,Gender.Male)              
            };

            var averageAgeByKind = animals
                .GroupBy(a => a.GetType());

            foreach (var typeAnimal in averageAgeByKind)
            {
                    Console.WriteLine("Animal type: {0}", typeAnimal.Key);

                foreach (var animal in typeAnimal)
                {
                    Console.WriteLine("\nAnimal name: {0} \nAnimal age: {1} \nAnimal gender: {2}"
                        , animal.Name, animal.Age, animal.Gender.ToString());                   
                }

                Console.WriteLine("\nAverage age is {0}", Animal.AverageAge(typeAnimal).ToString());
                Console.WriteLine();
            }
                
        }
    }
}
