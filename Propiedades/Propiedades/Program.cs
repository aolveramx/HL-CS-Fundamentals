using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale mySale = new Sale(100, DateTime.Now);
            mySale.Total = -1212;
            Console.WriteLine(mySale.Total);
        }
    }

    class Sale
    {
        private int total;
        private DateTime date;

        public string Date
        {
            get
            {
                return date.ToLongDateString();
            }
        }

        public int Total
        {
            get
            {
                return total;
            }

            set
            {
                if (value < 0)
                    value = 0;

                total = value;
            }
        }

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }
    }
}
