using System;

public class Term
{
    Constant _constant = null;
    Variable _variable = null;
    Exponent _exponent = null;
    public Term(Constant c, Variable v, Exponent e)
    {
        _constant = c;
        _variable = v;
        _exponent = e;
    }
    public Term(Constant c, Variable v)
    {
        _constant = c;
        _variable = v;
    }
    public Term(Constant c)
    {
        _constant = c;
    }
    public Term(Variable v)
    {
        _variable = v;
    }

    // My Generic Methods :|
    public Constant GetConstant()
    {
        return _constant;
    }

    public Variable GetVariable()
    {
        return _variable;
    }

    public Exponent GetExponent()
    {
        return _exponent;
    }

    // My Special Methods :D
    public string Display()
    {
        string s = "";

        // 1. Handle the Constant (Coefficient)
        if (_constant != null)
        {
            double val = _constant.GetNumber();
            // If val is 1 and there's a variable, we don't print the '1' in front of the variable
            if (val != 1 || _variable == null)
            {
                s += val.ToString();
            }
        }

        // 2. Handle the Variable
        if (_variable != null)
        {
            s += _variable.GetLetter();
        }

        // 3. Handle the Exponent
        if (_exponent != null)
        {
            // We reach into the exponent's constant to get the power
            // Note: You'll need a way to access the constant inside Exponent
            double power = _exponent.GetPower();
            if (power != 1) // Don't show ^1
            {
                s += Utility.ToSuperscript(power);
            }
        }

        return s;
    }

}