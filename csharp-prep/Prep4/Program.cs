//Jack Wilson
//CSE210
//C# Prep 4

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        double avg;
        int largestNumber = 0;

        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter a number (0 to exit): ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
            sum += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
            
        }
        avg = Convert.ToDouble(sum) / Convert.ToDouble(numbers.Count());

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}