//Problem 4. Person class

//Create a class Person with two fields – name and age. Age can be left unspecified 
//(may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality.

namespace PersonClass
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string someName)
        {
            this.name = someName;
        }

        public Person(string someName, int someAge)
        {
            this.name = someName;
            this.age = someAge;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length <2)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format("Name: {0} \nAge is unspecified", this.Name);             
            }
            else
            {
                return string.Format("Name: {0} \nAge: {1}", this.Name, this.Age.Value.ToString());

            }
        }
    }
}
