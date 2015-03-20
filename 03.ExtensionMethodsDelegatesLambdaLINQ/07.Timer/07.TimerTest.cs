﻿//Problem 7. Timer

//Using delegates write a class Timer that can execute certain method at each t seconds.

//Problem 8.* Events

//Read in MSDN about the keyword event in C# and how to publish events.
//Re-implement the above using .NET events and following the best practices.

namespace TimerTest
{
    using System;

    using MyTimer;

    class TimerTest
    {
        static void Main()
        {
            Timer seconds = new Timer(36);

            Timer.PrintSecond(seconds);
        }
    }
}
