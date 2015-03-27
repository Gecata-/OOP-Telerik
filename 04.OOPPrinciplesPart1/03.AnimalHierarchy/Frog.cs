﻿namespace AnimalHierarchy
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, int age, Gender sex)
            : base(name, age, sex)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Kvak");
        }
    }
}
