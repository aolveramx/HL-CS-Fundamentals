using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() 
            { 
                1, 2, 3 
            };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            var students = new List<People>()
            {
                new People() { Name = "Roberto", Country = "Mexico" },
                new People() { Name = "Hector", Country = "Argentina" },
                new People() { Name = "Sarah", Country = "US" }
            };

            Show(students);

            students.RemoveAt(2);

            Show(students);
        }

        static void Show(List<People> students)
        {
            Console.WriteLine("-- People --");
            foreach (var people in students)
            {
                Console.WriteLine($"Name: {people.Name}, Country: {people.Country}");
            }
        }
    }

    class People
    {
        public string Name { get; set; }
        public string Country { get; set; }    
    }
}