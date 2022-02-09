using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[7]
            {
                "Diane",
                "Nicole",
                "Aaron",
                "Mijali",
                "Nadja",
                "Ian",
                null
            };

            friends[0] = "Diana";

            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);
            Console.WriteLine(friends[3]);
            Console.WriteLine(friends[4]);
            Console.WriteLine(friends[5]);
            Console.WriteLine(friends[6]);

            friends[6] = "Anja";

            Console.WriteLine(friends[6]);

        }
    }
}
