namespace TimerTest.MyTimer
{
    using System;

    public class Timer
    {
        private int seconds;

        public Timer(int someSeconds)
        {
            this.seconds = someSeconds;
        }

        public int Seconds
        {
            get { return this.seconds; }
            set { }
        }

        public static void PrintSecond(Timer seconds)
        {
            for (int i = 1; i <= seconds.Seconds; i++)
            {
                Console.WriteLine("{0} second",i);
            }
        }
    }
}
