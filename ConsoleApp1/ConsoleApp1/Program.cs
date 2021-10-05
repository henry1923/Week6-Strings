using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Palun b:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Palun a:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Millist operaatorit: ");
            Console.WriteLine("Valikus operaatorid  \nLiitmine: + \nKorrutamine: *  \nLahutamine: -  \nJagamine: /");

            string operaator = Console.ReadLine();

            if (operaator == "*")
            {
                Console.WriteLine($"Tehe: {a * b}");
            }
            if (operaator == "+")
            {
                Console.WriteLine($"Tehe: {a + b}");
            }
            if (operaator == "/")
            {
                Console.WriteLine($"Tehe: {a / b}");
            }
            if (operaator == "-")
            {
                Console.WriteLine($"Tehe: {a - b}");
            }
        }
    }

}
