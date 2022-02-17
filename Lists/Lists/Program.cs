using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(2);

            Console.WriteLine(numbers.Count);

            List<int> numbersTwo = new List<int>()
            {
                1 ,2, 3, 4, 5, 6,
            };

            Console.WriteLine(numbersTwo.Count);

            numbersTwo.Add(55);
            Console.WriteLine(numbersTwo.Count);

            numbersTwo.Clear();
            Console.WriteLine(numbersTwo.Count);

            List<string> countries = new List<string>()
            {
                "Mexico", "Argentina", "España"
            };

            Console.WriteLine(countries.Count);

        }
    }
}