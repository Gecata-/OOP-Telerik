namespace TimerTest
{
    using System;

    using MyTimer;

    using System.Diagnostics;

    class TimerTest
    {
        static void Main()
        {
            Timer seconds = new Timer();

            Action<Timer> someDelegate = Timer.PrintSecond;

            someDelegate(seconds);
        }
    }
}
