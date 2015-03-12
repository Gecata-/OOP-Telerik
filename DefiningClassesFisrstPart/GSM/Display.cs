namespace GSM
{
    using System;

    public class Display
    {
        private double? displaySize;
        private int? displayNumberOfColors;

        public Display()
        {
            this.displaySize = null;
            this.displayNumberOfColors = null;
        }

        public Display(double displaySize, int numberOfColors)
        {
            this.displaySize = displaySize;
            this.displayNumberOfColors = numberOfColors;
        }

        public double? Size
        {
            get
            {
                return this.displaySize;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentNullException("Screen size must be more than 0");
                }
                else
                {
                    this.displaySize = value;
                }
            }
        }

        public int? NumberOFColors
        {
            get
            {
                return this.displayNumberOfColors;
            }
            set
            {
                if (value < 2)
                {
                    throw new ArgumentException("Colors must be more than 2");
                }
                else
                {
                    this.displayNumberOfColors = value;
                }
            }
        }
    }
}
