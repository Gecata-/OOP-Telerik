//Problem 5. Generic class

//Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
//Implement methods for adding element, accessing element by index, removing element by index, 
//inserting element at given position, clearing the list, finding element by its value and ToString().
//Check all input parameters to avoid accessing elements at invalid positions.

namespace DefiningClassesSecondPart.GenericClass
{
    using System;
    using System.Text;

    public class GenericList<T> where T : IComparable
    {
        private const int DEFAULT_CAPACITY = 4;
        private T[] arr;
        private int count = 0;
        private int capacity = DEFAULT_CAPACITY;

        public GenericList()
            : this(DEFAULT_CAPACITY)
        {
        }

        public GenericList(int capacity)
        {
            arr = new T[capacity];
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
        }

        //Problem 6. Auto-grow

        //Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.

        public void Add(T element)
        {
            if (count > capacity - 1)
            {
                this.capacity = capacity * 2;

                T[] temp = new T[capacity];

                for (int i = 0; i < arr.Length; i++)
                {
                    temp[i] = this.arr[i];
                }

                this.arr = new T[capacity];

                for (int i = 0; i < temp.Length; i++)
                {
                    arr[i] = temp[i];
                }

                this.arr[count] = element;
            }
            else
            {
                this.arr[count] = element;
            }
            count++;
        }

        private void CheckIfIndexIsValid(int index)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
        }

        public T this[int index]
        {
            get
            {
                CheckIfIndexIsValid(index);

                return this.arr[index];
            }
            set
            {
                CheckIfIndexIsValid(index);

                this.arr[index] = value;
            }
        }

        public void RemoveAt(int index)
        {
            CheckIfIndexIsValid(index);

            this.arr[index] = default(T);
        }

        public void Insert(int index, T element)
        {
            CheckIfIndexIsValid(index);

            T[] temp = new T[capacity + 1];

            for (int i = 0; i < index; i++)
            {
                temp[i] = this.arr[i];
            }

            temp[index] = element;

            for (int i = index + 1, j = index; i < arr.Length; i++, j++)
            {
                temp[i] = this.arr[j];
            }

            this.arr = temp;
        }

        public void ClearList()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                this.arr[i] = default(T);
            }
        }

        public int Find(T searched)
        {        
           return Array.IndexOf(this.arr,searched);
        }

        //Problem 7. Min and Max

        //Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
        //You may need to add a generic constraints for the type T

        public T Min()
        {
            T min = this.arr[0];
            

            for (int i = 0; i < this.arr.Length; i++)
            {
                if (min.CompareTo(this.arr[i]) > 0 && this.arr[i]!=null)
                {
                    min = this.arr[i];
                }
                
            }
            
            return min;
        }

        public T Max()
        {
            T max = this.arr[0];
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (max.CompareTo(this.arr[i]) < 0 && this.arr[i] != null)
                {
                    max = this.arr[i];
                }

            }
            return max;
        }

        public override string ToString()
        {
             StringBuilder arrToString = new StringBuilder();

            if (arr.Length>1)
            {
                for (int i = 0; i < this.count; i++)
                {
                    if (this.arr[i] == null)
                    {
                        arrToString.Append("");
                    }
                    else
                    {
                        arrToString.Append(arr[i].ToString());
                    }
                    
                    arrToString.Append(",\n");
                }  
            }

            return arrToString.ToString();
            
        }

    }
}
