using System;

public class Number : Constant
{
    private double _number;
    public Number(double number)
    {
        _number = number;
    }

    // My Special Methods :D
    public override double GetNumber()
    {
        return _number;
    }
}