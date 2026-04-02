using System;

public class Integral : Equation
{
    public Integral(Equation originalEquation)
    {
        List<Term> originalTerms = originalEquation.GetTerms();
        List<Term> newTerms = Integrate(originalTerms);

        foreach (Term t in newTerms)
        {
            this.AddTerm(t);
        }
    }
    public static List<Term> Integrate(List<Term> terms)
    {
        List<Term> newEquation = new List<Term>();
        foreach (Term t in terms)
        {
            // This is where the magic will happen. I need to be able to apply the Power Rule! The Constant is multiplied by the exponent, and the exponent goes down by one. If a number doesn't have a variable, it is chucked out.
            Constant c = t.GetConstant();
            Variable v = t.GetVariable();
            Exponent e = t.GetExponent();
            
            double currentPower;
            if (v == null)
            {
                currentPower = 0.0;
            }
            else if (e == null)
            {
                currentPower = 1.0;
            }
            else
            {
                currentPower = e.GetPower();
            }

            if (v == null)
            {
                v = new Variable('x');
            }

            double currentCoeff = (c != null) ? c.GetNumber() : 1.0;
            double newPower = currentPower + 1;

            if (newPower == 0)
            {
                Console.WriteLine("We cannot integrate -1 yet becuase it requires logorithmic functions... Sorry!");
                continue;
            }

            double newCoeff = currentCoeff / newPower;

            Number newConstant = new Number(newCoeff);
            if (newPower == 1)
            {
                newEquation.Add(new Term(newConstant, v));
            }
            else
            {
                Exponent newExponent = new Exponent(new Number(newPower));
                newEquation.Add(new Term(newConstant, v, newExponent));
            }

        }
        Variable constantC = new Variable('C');
        newEquation.Add(new Term(constantC));
        return newEquation;
    }
}