using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        int userGuess = -1;

        while (userGuess != number)
        {
            Console.WriteLine("Make your Guess: ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You Guessed it!");
            }
        }
    }
}