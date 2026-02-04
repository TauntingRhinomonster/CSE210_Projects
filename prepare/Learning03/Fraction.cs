using System;

class Fraction
{
    private int _numerator;
    private int _denominator;
    public Fraction()
    {
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
        return $"{_numerator}/{_denominator}";
    }
    // Creating the decimal value of the fraction
    public double GetDecimalValue()
    {
        return _numerator / _denominator;
    }
}