using System;

namespace FullNameReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi.");
            string userFirstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonna nimi.");
            string userLastName = Console.ReadLine();
            for (int i = userFirstName.Length -1; i>= 0; i--)
            {
                Console.Write(userFirstName[i]);
            }
        }
    }
}
