//  Problem 3. Range Exceptions

//  Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
//  It should hold error message and a range definition [start … end].
//  Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> 
//  by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

namespace RangeExceptionsTest
{
    using RangeExceptions;

    using System;

    class RangeExceptionsTest
    {
        static void Main()
        {
            //int

            int max= 100;
            int min = 1;

            var rangeIntException = new InvalidRangeException<int>("Invalid range", min,max);

            long result = 0;
     
            try
            {
                result = (long)max * 2;

                if (result > rangeIntException.End || result < rangeIntException.Start )
                {
                    throw rangeIntException;
                }
            }
            catch(InvalidRangeException<int> ex)
            {
                Console.WriteLine("{0}, values must be between {1} and {2}", ex.Message, min, max);
            }

            //DateTime
            
            DateTime start = DateTime.Parse("1.1.1980");
            DateTime end = DateTime.Parse("31.12.2013");

            var rangeDateException = new InvalidRangeException<DateTime>("Invalid date", start, end);

            try
            {
                DateTime today = DateTime.Now;

                if (today < rangeDateException.Start || today > rangeDateException.End)
                {
                    throw rangeDateException;
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {

                Console.WriteLine("{0}, date must be between {1:dd/MM/yyyy} and {2:dd/MM/yyyy}", ex.Message, start, end);
            }
        }
    }
}
