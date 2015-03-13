
namespace GSM
{
    using System;

    public class Call
    {
        private DateTime date;
        private ulong time;
        private string dialedNumber;
        private ulong duration;

        public Call(DateTime someDate, ulong someTime, string someDialedNumber, ulong someDuration)
        {
            this.date = someDate;
            this.time = someTime;
            this.dialedNumber = someDialedNumber;
            this.duration = someDuration;
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            private set
            {
                this.date = DateTime.Today;
            }
        }

        public ulong Time
        {
            get
            {
                return time;
            }
            set
            {
                if (value > 0)
                    this.time = value;                
            }
        }

        public string DialedNumber
        {
            get
            {
                return dialedNumber;
            }
            set
            {
                if (value.ToString().Length>=3)
                {
                    this.dialedNumber = value;
                }
            }
        }

        public ulong Duration
        {
            get
            {
                return duration;
            }
            set
            {
                if (value > 0)
                {
                    this.duration = value;
                }
            }
        }

        public override string ToString()
        {
            DateTime someDate = this.date;
            string someTime = this.time.ToString();
            string someDialedNumber = this.dialedNumber;
            string someDuration = this.duration.ToString();

            return "\nCall date: " + someDate + "\nTime:" + someTime + "\nDialed number: "+ someDialedNumber + "\nDuration of call: " + someDuration;
        }
    }
}
