//Problem 5. 64 Bit array

//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace BitArray64
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong ulongNumber)
        {
            this.number = ulongNumber;
        }

        public ulong Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            return this.Number.Equals((obj as BitArray64).Number);
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public int this[int pos]
        {
            get
            {
                if (pos < 0 || pos >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                return ((int)(this.Number >> pos) & 1);
            }
            set
            {
                if (pos < 0 || pos >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid bit value.");
                }

                if (((int)(this.Number >> pos) & 1) != value)
                {
                    this.Number ^= (1ul << pos);
                }
            }
        }
        

        public static bool operator ==(BitArray64 arr1, BitArray64 arr2)
        {
            return (arr1.Equals(arr2));
        }

        public static bool operator !=(BitArray64 arr1, BitArray64 arr2)
        {
            return !(arr1.Equals(arr2));
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int pos = 0; pos < 64; pos++)
            {
                result.Insert(0, ((this.Number >> pos) & 1));
            }

            return result.ToString();
        }
    }
}
