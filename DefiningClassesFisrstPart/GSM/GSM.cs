namespace GSM
{
    using System;

    public class GSM
    {
        private string phoneModel;
        private string phoneManufacturer;
        private double? phonePrice;
        private string phoneOwner;
        private Battery battery;
        private Display display;
        private static GSM iPhone4S;

  

        public GSM(string model, string manufacturer)
        {
            this.phoneModel = model;
            this.phoneManufacturer = manufacturer;
            this.phonePrice = null;
            this.phoneOwner = null;
        }

        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
        {
            this.phoneModel = model;
            this.phoneManufacturer = manufacturer;
            this.phonePrice = price;
            this.phoneOwner = owner;
            this.battery = battery;
            this.display = display;
        }

        static GSM()
        {
            iPhone4S = new GSM("Iphone 4S", "Apple", 600, "Georgi",
                                         new Battery("Non-removable Li-Po 1432 mAh battery (5.3 Wh)", 200, 14,
                                         BatteryType.LiPo), new Display(3.5, 16777216));
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public string Model
        {
            get
            {
                return this.phoneModel;
            }
            set
            {
                if (value.Length == 0 || value.Length > 15)
                {
                    throw new ArgumentOutOfRangeException("Invalid Phone Name!");
                }
                else
                {
                    this.phoneModel = value;
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.phoneManufacturer;
            }
            set
            {
                if (value.Length < 1 || value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("Invalid manufacturer name!");
                }
                else
                {
                    this.phoneManufacturer = value;
                }
            }
        }

        public double? Price
        {
            get
            {
                return this.phonePrice;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price must be more than 0");
                }
                else
                {
                    this.phonePrice = value;
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.phoneOwner;
            }
            set
            {
                if (value.Length < 1 || value.Length > 40)
                {
                    throw new ArgumentOutOfRangeException("Invalid owner name");
                }
                else
                {
                    this.phoneOwner = value;
                }
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
        }

        public override string ToString()
        {
            string model = this.phoneModel;
            string manufacturer = this.phoneManufacturer;
            string price = this.phonePrice.ToString();
            string owner = this.phoneOwner;
            string batteryType = this.battery.Type;
            string idleHours = this.battery.IdleHours.ToString();
            string batteryModel = this.battery.Model;
            string batteryTalkTime = this.battery.TalkHours.ToString();
            string displaySize = this.display.Size.ToString();
            string colorsNumber = this.display.NumberOFColors.ToString();

            return "Model: " + model + "\nManufacturer: " + manufacturer + "\nPrice: " + price +
                "\nOwner: " + owner + "\nBattery type: " + batteryType + "\nBattery idle hours: " + idleHours + "\nBattery model: " + batteryModel +
                "\nBattery talk time: " + batteryTalkTime + "\nDisplay size: " + displaySize + "\nDisplay number of colors: " + colorsNumber;

        }

    }
}
