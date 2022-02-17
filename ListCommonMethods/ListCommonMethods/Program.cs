using System.Collections.Generic;

namespace ListCommonMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> 
            { 
                1, 2, 3, 4
            };

            Show(numbers);

            numbers.Insert(0, 100);

            Show(numbers);

            // Contains
            if (numbers.Contains(33))
            {
                Console.WriteLine("Exist");
            }
            else
            {
                Console.WriteLine("Does not exist");
            }

            // IndexOf
            int position = numbers.IndexOf(90);
            Console.WriteLine(position);

            // Sort - mutable
            numbers.Sort();
            Show(numbers);

            // strings are not mutable, lists are mutable
            string name = "Ari";
            name = name.ToUpper();
            Console.WriteLine(name);

            // Add Range
            numbers.AddRange(new List<int>()
            {
                300, 600, 200
            });

            Show(numbers);
        }

        public static void Show(List<int> numbers)
        {
            Console.WriteLine("-- Numbers --");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}