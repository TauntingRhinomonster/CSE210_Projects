using System;

public class Derivative : Equation
{
    public List<Term> _derivative;
    public Derivative(List<Term> equation)
    {
        _derivative = Derive(equation);
    }
    public static List<Term> Derive(List<Term> equation)
    {
        List<Term> newEquation = new List<Term>(equation);
        return newEquation;
    }
}