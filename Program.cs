using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;
            int guesses = 1;
            while (guesses < 5){
            Console.WriteLine();
            Console.WriteLine("Guess the secret number");
            string guess = Console.ReadLine();

            if (Int32.Parse(guess) == secretNumber){
                Console.WriteLine("Correct!");
                break;
            } else {
                Console.WriteLine( Int32.Parse(guess) > secretNumber ?
                    $"Incorrect, try a lower number! You may try {4 - guesses} more times!" : $"Incorrect, try a higher number! You may try {4 - guesses} more times!");
            }
            guesses++;
            }
        }
    }
}
