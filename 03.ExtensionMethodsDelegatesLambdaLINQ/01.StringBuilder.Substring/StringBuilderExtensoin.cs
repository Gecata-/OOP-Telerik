//  Problem 1. StringBuilder.Substring

//  Implement an extension method Substring(int index, int length) for the class StringBuilder that 
//  returns new StringBuilder and has the same functionality as Substring in the class String.

namespace MyStringBuilder.Substring
{
    using System;

    using System.Text;

    public static class StringBuilderExtensoin
    {
        public static StringBuilder Substring(this StringBuilder someStringBuilder, int index, int length)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("ArgumentOutOfRange_StartIndex");
            }
            if (index > someStringBuilder.Length)
            {
                throw new ArgumentOutOfRangeException("ArgumentOutOfRange_StartIndexLargerThanLength");
            }
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException("ArgumentOutOfRange_NegativeLength");
            }
            if (index > someStringBuilder.Length - length)
            {
                throw new ArgumentOutOfRangeException("ArgumentOutOfRange_IndexLength");
            }
            if (length == 0)
            {
                return someStringBuilder.Clear();
            }
            if (index == 0 && length == someStringBuilder.Length)
            {
                return someStringBuilder;
            }
            string temp = someStringBuilder.ToString();

            var result = temp.Substring(index, length);

            var resultStringBuilder = new StringBuilder(result);

            return resultStringBuilder;
        }
    }
}
