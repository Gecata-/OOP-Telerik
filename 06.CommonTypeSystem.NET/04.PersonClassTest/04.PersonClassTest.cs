namespace PersonClassTest
{
    using PersonClass;

    using System;

    public class PersonClassTest
    {
        static void Main()
        {
            var test1 = new Person("William Uolles");
            var test2 = new Person("Drakula", 1000);

            Console.WriteLine(test1);
            Console.WriteLine(test2);
        }
    }
}
