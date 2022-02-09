using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Iteration" + i);
                i++;
            }

            int j = 0;

            while (j < 100)
            {
                if (j > 10)
                    break;

                Console.WriteLine("Iteration" + i);
                j++;
            }

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

            int index = 0;
            while (index < friends.Length)
            {
                Console.WriteLine(friends[index]);
                index++;
            }

            bool run = false;
            do
            {
                Show();
            } while (run);
        }

        static void Show()
        {
            Console.WriteLine("Runs at least once");
        }
    }
}
