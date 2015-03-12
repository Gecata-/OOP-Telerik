namespace GSM
{
    using System;
    public class Battery
    {
        private string batteryModel;
        private double? batteryHoursIdle;
        private double? batteryHoursTalk;
        private BatteryType batteryType;

        public Battery(string model)
        {
            this.batteryModel = model;
            this.batteryHoursIdle = null;
            this.batteryHoursTalk = null;
        }

        public Battery(string model, double batteryHoursIdle, double batteryHoursTalk, BatteryType batteryType)
        {
            this.batteryModel = model;
            this.batteryHoursIdle = batteryHoursIdle;
            this.batteryHoursTalk = batteryHoursTalk;
            this.batteryType = batteryType;
        }

        public string Model
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                if (value.Length < 5 || value.Length > 100)
                {
                    throw new ArgumentOutOfRangeException("Invalid battery model");
                }
                else
                {
                    this.batteryModel = value;
                }
            }
        }

        public double? IdleHours
        {
            get
            {
                return this.batteryHoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Invalid battery idle hours");
                }
                else
                {
                    this.batteryHoursIdle = value;
                }
            }
        }

        public double? TalkHours
        {
            get
            {
                return this.batteryHoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Battery talk hours must be more than 0");
                }
                else
                {
                    this.batteryHoursTalk = value;
                }
            }
        }

        public string Type
        {
            get
            {
                return this.batteryType.ToString();
            }
        }
    }
}
