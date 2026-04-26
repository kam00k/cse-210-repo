//Jack Wilson
//CSE210
//C# Prep 3

using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        bool guessedRight = false;
        Console.WriteLine("Try to guess the number!");
        int magicNumber = new Random().Next(1, 101);
        while (guessedRight == false)
        {
            Console.Write("What is your guess? ");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                guessedRight = true;
            }
        }
        Console.Write("You guessed it!");
    }
}