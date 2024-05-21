using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Fraction object with default constructor
        Fraction f1 = new Fraction();
        // Print the fraction as a string
        Console.WriteLine(f1.GetFractionString());
        // Print the decimal value of the fraction
        Console.WriteLine(f1.GetDecimalValue());

        // Create a Fraction object with the numerator provided
        Fraction f2 = new Fraction(5);
        // Print the fraction as a string
        Console.WriteLine(f2.GetFractionString());
        // Print the decimal value of the fraction
        Console.WriteLine(f2.GetDecimalValue());

        // Create a Fraction object with both numerator and denominator provided
        Fraction f3 = new Fraction(3, 4);
        // Print the fraction as a string
        Console.WriteLine(f3.GetFractionString());
        // Print the decimal value of the fraction
        Console.WriteLine(f3.GetDecimalValue());

        // Create a Fraction object with both numerator and denominator provided
        Fraction f4 = new Fraction(1, 3);
        // Print the fraction as a string
        Console.WriteLine(f4.GetFractionString());
        // Print the decimal value of the fraction
        Console.WriteLine(f4.GetDecimalValue());
    }
}