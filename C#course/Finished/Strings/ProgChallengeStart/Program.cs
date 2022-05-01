using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int guessNum = 0, num = 0, theNumber = new Random().Next(20);
            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");// Start the game and run until user quits or guesses correctly
            do
            {
                string guess = Console.ReadLine();
                bool result = Int32.TryParse(guess, out guessNum);
                // Keep track of the number of guesses and the current user guess
                num++;
                if (guessNum > theNumber)
                {
                    Console.WriteLine("Ohhh whoops you guessed a little too high");
                }
                else if (guessNum < theNumber)
                {
                    Console.WriteLine("Ohhh whoops you guessed a little too low");
                }
                else if (guessNum == -1)
                {
                    Console.WriteLine("You have quit the game");
                    break;
                }
                else
                {
                    Console.WriteLine("Congrats You guessed the number right in " + num + " guesses");
                }
            } while (theNumber != guessNum);
        }
    }
}
