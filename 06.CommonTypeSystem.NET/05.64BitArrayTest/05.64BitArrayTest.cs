namespace BitArrayTest
{
    using BitArray64;

    using System;
    using System.Collections.Generic;


    class BitArrayTest
    {
        static void Main()
        {
            var bit1 = new BitArray64(123456789);
            var bit2 = new BitArray64(123456789);
            var bit3 = new BitArray64(1);
            var bit4 = new BitArray64(1);

            Console.WriteLine(bit1);

            Console.WriteLine(bit1[8]);

            bit1[63] = 1;

            Console.WriteLine(bit1);

            Console.WriteLine(bit1.GetHashCode());

            Console.WriteLine(bit3.Equals(bit4)); //true
            Console.WriteLine(bit1.Equals(bit3)); //false

            Console.WriteLine(bit1 != bit2); //true

            Console.WriteLine(bit3 == bit4); //true

            var bitArr = new List<BitArray64>
            {
                {new BitArray64(1)},
                {new BitArray64(2)},
                {new BitArray64(3)},
                {new BitArray64(99999999999)}
            };

            foreach (var bitNumber in bitArr)
            {
                Console.WriteLine(bitNumber);
            }
        }
    }
}
