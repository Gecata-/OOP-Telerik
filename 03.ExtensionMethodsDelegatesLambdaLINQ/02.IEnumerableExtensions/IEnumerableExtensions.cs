//Problem 2. IEnumerable extensions

//Implement a set of extension methods for IEnumerable<T> that 
//implement the following group functions: sum, product, min, max, average.

namespace MyIEnumerable.Extensions
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    

    public static class IEnumerableExtensions
    {
        //sum

        public static T Sum<T>(this IEnumerable<T> collection)
        {
            CheckColection(collection);

            dynamic result = 0; 

            foreach (var item in collection)
            {
                result += item;
            }

            return result;
        }

        //product

        public static T Product<T>(this IEnumerable<T> collection)
        {
            CheckColection(collection);

            dynamic result = 1;

            foreach (var item in collection)
            {
                result *= item;
            }

            return result;
        }

        //min

        public static T Min<T>(this IEnumerable<T> collection)
            where T:IComparable
        {
            CheckColection(collection);

            T min = collection.First();

            foreach (var item in collection)
            {
                if (item.CompareTo(min) <0)
                {
                    min = item;
                }
            }

            return min;
        }

        //max

        public static T Max<T>(this IEnumerable<T> collection)where T:IComparable
        {
            CheckColection(collection);

            T max = collection.First();

            foreach (var item in collection)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        //average

        public static T Average<T>(this IEnumerable<T> collection)
        {
            CheckColection(collection);

            dynamic sum = 0;

            foreach (var item in collection)
            {
                sum += item;
            }

            T result = sum / collection.Count(x => x != null);

            return result;
        }

        private static void CheckColection<T>(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }
        }


    }
}
