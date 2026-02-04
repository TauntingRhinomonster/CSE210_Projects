using System;

class Fraction
{
    private int _numerator = 1;
    private int _denominator = 1;
    private string fraction;
    // The following are constructors for the fraction class
    public Fraction()
    {
        fraction = GetFractionString();
    }
    public Fraction(int numerator)
    {
        _numerator = numerator;
        fraction = GetFractionString();
    }
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
        fraction = GetFractionString();
    }
    // Creating the Get and Set Methods
    public void SetNumerator(int num)
    {
        _numerator = num;
    }
    public void SetDenominator(int num)
    {
        _denominator = num;
    }
    public int GetNumerator()
    {
        return _numerator;
    }
    public int GetDenominator()
    {
        return _denominator;
    }
    // Creating the string of the fraction
    public string GetFractionString()
    {
        return fraction = $"{_numerator}/{_denominator}";
    }
    // Creating the decimal value of the fraction
    public double GetDecimalValue()
    {
        double number = _numerator / (double)_denominator;
        if (_denominator == 0)
        {
            return 0;
        }
        // Return the number rounded to the hundredths place
        return Math.Round(number, 2);
    }
}