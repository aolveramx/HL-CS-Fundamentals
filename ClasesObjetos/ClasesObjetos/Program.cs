using System;

namespace ClasesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale saleOne = new Sale(100, DateTime.Now);
            Sale saleTwo = new Sale(200, DateTime.Now);
            Console.WriteLine(saleOne.GetInfo());
            Console.WriteLine(saleTwo.GetInfo());
        }
    }

    class Sale
    {
        int total;
        DateTime date;

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

        public string GetInfo()
        {
            return total + " " + date.ToLongDateString();
        }
        public void Show()
        {
            Console.WriteLine("Im a sale");
        }
    }
}
