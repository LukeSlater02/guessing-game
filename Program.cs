using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;
            int guesses = 0;
            double guessesMax = 0;
            

            Console.WriteLine("Choose a difficulty level: Easy (8 guesses), Medium (6 guesses) or Hard (4 guesses), or be a filthy cheater...");

            string difficulty = Console.ReadLine();
            if (difficulty.ToLower() == "easy")
            {
                guessesMax = 8;
            }
            else if (difficulty.ToLower() == "medium")
            {
                guessesMax = 6;
            }
            else if (difficulty.ToLower() == "hard")
            {
                guessesMax = 4;
            }
            else if (difficulty.ToLower() == "cheater")
            {
                guessesMax = Double.PositiveInfinity;
            }
            else
            {
                Console.WriteLine("Invalid difficulty input. Try again:");
                difficulty = Console.ReadLine();
            }

            while (guesses <= guessesMax)
            {
                Console.WriteLine();
                Console.WriteLine("Guess the secret number:");
                string guess = Console.ReadLine();

                if (Int32.Parse(guess) == secretNumber)
                {
                    Console.WriteLine("Correct!");
                    break;
                }
                else
                {
                    Console.WriteLine(Int32.Parse(guess) > secretNumber ?
                        $"Incorrect, try a lower number! You may try {guessesMax - 1 - guesses} more times!" : $"Incorrect, try a higher number! You may try {guessesMax - 1 - guesses} more times!");
                }
                guesses++;
            }
        }
    }
}
