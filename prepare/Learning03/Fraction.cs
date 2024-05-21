using System;

public class Fraction
{
    // Private fields to store the numerator (_top) and denominator (_bottom) of the fraction
    private int _top;
    private int _bottom;

    // Default constructor that initializes the fraction to 1/1
    public Fraction()
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }

    // Constructor that initializes the fraction with a whole number (top/1)
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor that initializes the fraction with given numerator and denominator
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Method to get the fraction as a string in the format "numerator/denominator"
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    // Method to get the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}
