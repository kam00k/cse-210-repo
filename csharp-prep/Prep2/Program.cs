//Jack Wilson
//CSE210
//C# Prep 2

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade = Convert.ToInt32(Console.ReadLine());

        char letterGrade;

        if (grade < 60)
        {
            letterGrade = 'F';
        }
        else if (grade < 70)
        {
            letterGrade = 'D';
        }
        else if (grade < 80)
        {
            letterGrade = 'C';
        }
        else if (grade < 90)
        {
            letterGrade = 'B';
        }
        else
        {
            letterGrade = 'A';
        }


        Console.WriteLine($"Your grade for this course is {letterGrade}.");
        if (grade > 70)
        {
            Console.WriteLine("You passed! Congratulations");
        }
        else
        {
            Console.WriteLine("You did not achieve a passing grade. Try again next time.");
        }
        
    }
}