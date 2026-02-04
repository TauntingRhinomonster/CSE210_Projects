using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning 03 World!");
        Fraction _basicFraction = new Fraction();
        Fraction _commonFraction = new Fraction(10);
        Fraction _uncommonFraction = new Fraction(2, 3);
        Console.WriteLine($"This is the first number: {_basicFraction.GetFractionString()}");
        Console.WriteLine($"This is the second number: {_commonFraction.GetFractionString()}");
        Console.WriteLine($"This is the third number: {_uncommonFraction.GetFractionString()}");
        Console.WriteLine($"This is the first number: {_basicFraction.GetDecimalValue()}");
        Console.WriteLine($"This is the second number: {_commonFraction.GetDecimalValue()}");
        Console.WriteLine($"This is the third number: {_uncommonFraction.GetDecimalValue()}");

        // Step 7: Additional Practice
        Console.WriteLine("This is the beginning of a loop.");
        int i = 0;
        while (i < 21)
        {
            Fraction _fraction = new();
            Random _num = new();
            int _numberN = _num.Next(1, 21);
            int _numberD = _num.Next(1, 21);
            _fraction.SetNumerator(_numberN);
            _fraction.SetDenominator(_numberD);
            Console.WriteLine($"String {i}: {_fraction.GetFractionString()}");
            Console.WriteLine($"Decimal {i}: {_fraction.GetDecimalValue()}");
            i++;
        }
        Console.WriteLine("The End.");
    }
}