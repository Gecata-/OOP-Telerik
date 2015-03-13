
namespace GSM
{
    public class GSMTest
    {
        private static GSM[] testPhones = new GSM[4]
        {
            new GSM("A6","Siemens",15,"Kosta",new Battery("Akai"),new Display(3.2,2)),
            new GSM("3210","Nokia",5,"Orhan",new Battery("Nokia",360,48.3,BatteryType.NiCd),new Display(2.7,2)),
            new GSM("3GS","Apple",15,"Todor",new Battery("Apple"),new Display(4.2,16000000)),
            new GSM("Vertu","Ferrary")
        };

        public static GSM[] TestGSM 
        {
            get
            {
                return testPhones;
            }
        }
    }
}
