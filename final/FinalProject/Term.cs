using System;

public class Term
{
    Constant _constant;
    Variable _variable;
    Exponent _exponent;
    public Term(Constant c, Variable v, Exponent e)
    {
        _constant = c;
        _variable = v;
        _exponent = e;
    }

    public void Display()
    {
        Console.WriteLine();
    }

}