
namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(string message,T someStart, T someEnd)
            :base(message)
        {
            this.start = someStart;
            this.end = someEnd;
        }

        public T Start
        {
            get
            {
                return this.start;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }
        }
    }
}
