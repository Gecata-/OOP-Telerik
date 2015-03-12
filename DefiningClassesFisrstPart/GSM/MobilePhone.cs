namespace GSM
{
    using System;

    class MobilePhone
    {
        public static void Main()
        {

            Battery phoneBattery = new Battery("Samsung", 124.5, 12.30, BatteryType.NiMH);
            Display phoneDisplay = new Display(14.5, 16000000);
            GSM Samsung = new GSM("S6", "Samsung", 900, "Kondio", phoneBattery, phoneDisplay);

            Console.WriteLine("{0}", Samsung);
            Console.WriteLine();

            GSM iPhone4S = GSM.IPhone4S;
           
            Console.WriteLine("{0}", iPhone4S);


        }
    }
}
