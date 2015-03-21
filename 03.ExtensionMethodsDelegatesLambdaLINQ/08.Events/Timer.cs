
//Problem 8.* Events

//Read in MSDN about the keyword event in C# and how to publish events.
//Re-implement the above using .NET events and following the best practices.

namespace TimerTest.MyTimer
{
    using SomeEvent;

    using System;
    using System.Diagnostics;

    public class Timer
    {
        public event EventHandler CustomEvent;

        private Stopwatch sw = new Stopwatch();

        private long seconds;

        public Timer()
        {
            sw.Start();

           this.seconds = sw.Elapsed.Ticks;

            sw.Stop();
        }

        public long Seconds
        {
            get
            {
                return this.seconds;
            }
        }

        public static void PrintSecond(Timer seconds)
        {
            
            for (int i = 1; i <= seconds.Seconds; i++)
            {
                Console.WriteLine("{0} second", i);
            }
        }
    }
}
