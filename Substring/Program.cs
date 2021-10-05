using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string Helloworld = "Helloworld!";
            string partToLookFor = "Hello";
            bool isThere;
            isThere = Helloworld.ToLower().Contains(partToLookFor);

            if(isThere)
            {
                Console.WriteLine($"Leidsin {partToLookFor} üles!");
            }
            else
            {
                Console.WriteLine($"Ei leindnud {partToLookFor} üles!");
            }
        }
    }
}
