using System;

namespace NumberGuesserStevenSuviste
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Steven Suviste";

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            while (true)
            {

                Random randomNumber = new Random();

                int correctNumber = randomNumber.Next(1, 11);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.WriteLine("Character is not a number. Please enter a number.");

                        Console.ResetColor();

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.WriteLine("Wrong number, please try again.");

                        Console.ResetColor();
                    }
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("You are correct!");

                Console.ResetColor();

                Console.WriteLine("Would you like to play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }
    }
}
