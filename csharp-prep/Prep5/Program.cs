//Jack Wilson
//CSE210
//C# Prep 5

using System;
using System.Runtime.CompilerServices;

    
class Program
{
    static void Main(string[] args)
    {
        int year;
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        PromptUserBirthYear(out year);
        int squareNum = SquareNumber(num);
        DisplayResult(name, squareNum, year);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = Convert.ToInt32(Console.ReadLine());
        return favoriteNumber;
    }

    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        year = Convert.ToInt32(Console.ReadLine());

    }

    static int SquareNumber(int num)
    {
        int squareNum = num * num;
        return squareNum;
    }

    static void DisplayResult(string name, int squaredNum, int birthYear)
    {
        int ageThisYear = DateTime.Now.Year - birthYear;
        Console.WriteLine($"{name}, the square of your number is {squaredNum}.");
        Console.WriteLine($"{name}, you will turn {ageThisYear} this year.");
    }
    
}

    
