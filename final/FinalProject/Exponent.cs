using System;

public class Exponent
{
    Constant _constant;
    Variable _variable;
    List<Term> _equation = null;
    public Exponent(Constant c, Variable v)
    {
        _constant = c;
        _variable = v;
    }
    public Exponent(Constant c)
    {
        _constant = c;
    }

    public double GetPower()
    {
        return _constant.GetNumber();
    }
}