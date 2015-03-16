//Problem 4. Path

//Create a class Path to hold a sequence of points in the 3D space.
namespace PointIn3DCoordinate
{
    using System;

    public class Path<T>
    {
        private const int defaultCapacity = 4;
        private T[] points3D;
        private int count = 0;
        private int capacity = defaultCapacity;

        public Path()
            : this(defaultCapacity)
        {
        }

        public Path(int capacity)
        {
            points3D = new T[capacity];
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

        public void Add(T element)
        {
            if (count > points3D.Length - 1)
            {
                T[] temp = new T[capacity];

                for (int i = 0; i < points3D.Length; i++)
                {
                    temp[i] = points3D[i];
                }

                this.points3D = new T[capacity * 2];

                for (int j = 0; j < temp.Length; j++)
                {
                    points3D[j] = temp[j];
                }
                this.capacity = capacity * 2;
            }

            this.points3D[count] = element;

            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > count)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.points3D[index];

            }
            set
            {
                if (index < 0 || index > count)
                {
                    throw new IndexOutOfRangeException();
                }

                points3D[index] = value;
            }
        }
    }
}
