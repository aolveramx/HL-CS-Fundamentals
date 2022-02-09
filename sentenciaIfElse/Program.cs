using System;

namespace sentenciaIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool areYouHungry = true;
            bool haveYouMoney = true;

            if(areYouHungry && haveYouMoney && IsRestaurantOpen("lonches pepe", 10))
            {
                Console.WriteLine("Time to eat");
            }
            else
            {
                Console.WriteLine("No lunch time");
            }
        }

        static bool IsRestaurantOpen(string name, int hour = 0)
        {
            if (name == "lonches pepe" && hour > 8 && hour < 23)
            {
                return true;
            }
            else if (name == "24 hours restaurant")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
