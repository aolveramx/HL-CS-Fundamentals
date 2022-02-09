using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 7;

            switch (op)
            {
                case 1:
                    Console.WriteLine("you selected one");
                    break;
                case 2:
                    Console.WriteLine("you selected two");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("you selected option three and four");
                    break;
                case < 0:
                case > 100:
                    Console.WriteLine("out of range");
                    break;
                case > 4 and < 10:
                    Console.WriteLine("range between four and ten");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }
        }
    }
}
