using System;
using System.Security.Cryptography.X509Certificates;

public class Fraction : Constant
{
    int _numerator;
    int _denominator;
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public int GetNumerator()
    {
        return _numerator;
    }
    public int GetDenominator()
    {
        return _denominator;
    }

    // My Special Methods
    public double GetDecimal(int a, int b)
    {
        double num = (double)a/b;
        return num;
    }
    public override double GetNumber()
    {
        return GetDecimal(_numerator, _denominator);
    }
}