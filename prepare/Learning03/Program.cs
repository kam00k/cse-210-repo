//Jack Wilson
//CSE210
//Encapsulation Learning Activity

using System;

class Program
{
    static void Main(string[] args)
    {
        //Create 4 new fraction objects
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(12);
        Fraction fraction3 = new Fraction(3,7);
        Fraction fraction4 = new Fraction(1,16);

        //Test the functions of the Fraction class
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetNumerator());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction4.GetDenominator());

        //Create a random object and another Fraction object
        Random randInt = new Random();
        Fraction testFraction = new Fraction();

        //Loop 25 times
        for (int i = 1; i < 26; i++)
        {
            //set the numerator and denominator to a random number between 1 and 9
            testFraction.SetNumerator(randInt.Next(1,10));
            testFraction.SetDenominator(randInt.Next(1,10));

            //output each Fraction's decimal and string form to the console
            Console.WriteLine($"Fraction: {i} | String: {testFraction.GetFractionString()} | Decimal: {testFraction.GetDecimalValue()}");
        }
    }
}