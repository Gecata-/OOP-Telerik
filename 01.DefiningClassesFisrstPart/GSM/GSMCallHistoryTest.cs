//Problem 12. Call history test
//Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.

namespace GSM
{
    using System;
    using System.Collections.Generic;

    class GSMCallHistoryTest
    {
        static void Main()
        {
            //// Uncomment to test :)

            //GSM[] test = GSMTest.TestGSM;
            //for (int i = 0; i < test.Length; i++)
            //{
            //    Console.WriteLine("{0}", test[i]);
            //    Console.WriteLine();
            //}

            //GSM iPhone4S = GSM.IPhone4S;

            //Console.WriteLine("{0}", iPhone4S);

            int numberOfCalls = 5;
            decimal price = 0;
            ulong maxDuration = 0;
            int index = 0;
            List<Call> phoneCallHistory = new List<Call>();

            //Create an instance of the GSM class.
            GSM Nokia = new GSM("888", "Nokia", 999.9, "DeDaBqhAz", new Battery("Nokia", 800.5, 200.6, BatteryType.LiIon), new Display(20.7, 99000000), phoneCallHistory);

            //Add few calls.
            for (int i = 0, j = 0; j < numberOfCalls; i++, j++)
            {
                Nokia.AddCallToHistory(new Call(DateTime.Today, (15 + (ulong)i), (0888123456 + (i += 100)).ToString("D10"), (60 + (ulong)(i += 23))));
            }

            //Display the information about the calls.
            foreach (var call in phoneCallHistory)
            {
                Console.WriteLine(call);
            }

            //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            price = Nokia.CallPrice(0.37m);

            Console.WriteLine("\nTotal price of the calls in history: {0}\n", price);

            //Remove the longest call from the history and calculate the total price again.
            for (int i = 0; i < phoneCallHistory.Count; i++)
            {
                if (phoneCallHistory[i].Duration > maxDuration)
                {
                    maxDuration = phoneCallHistory[i].Duration;
                    index = i;
                }
            }

            Nokia.RemoveCallFromHistory(phoneCallHistory, index);
            price = Nokia.CallPrice(0.37m);

            Console.WriteLine("\nTotal price of the calls in history: {0}\n", price);

            //Finally clear the call history and print it.
            Console.WriteLine(new string('*', 30));
            Nokia.ClearHistory(phoneCallHistory);

            foreach (var call in phoneCallHistory)
            {
                Console.WriteLine(call);
            }
            Console.WriteLine(new string('*', 30));
        }
    }
}
