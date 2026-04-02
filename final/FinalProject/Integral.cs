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
            // Basically, if there is no exponent just go onto the next "t" in terms
            if (v == null)
            {
                continue;
            }

            // We use Ternary operators to check really quickly if the coefficient is not null. We do the same with the exponent. If it isn't null, we call the GetNumber() method. If it is, we set it equal to 1.0 which is saved as a double.
            double currentCoeff = (c != null) ? c.GetNumber() : 1.0;
            double currentPower = (e != null) ? e.GetPower() : 1.0;

            // Do the simple POWER RULE MATH BABY!!!!
            double newCoeff = currentCoeff * currentPower;
            double newPower = currentPower - 1;
            // Now we save that as new variables and add them to the new equation
            Number newConstant = new(newCoeff);
            if (newPower == 0)
            {
                newEquation.Add(new Term(newConstant));
            }
            else if (newPower == 1)
            {
                newEquation.Add(new Term(newConstant, v));
            }
            else
            {
                Exponent newExponent = new Exponent(new Number(newPower));
                newEquation.Add(new Term(newConstant, v, newExponent));
            }
        }
        return newEquation;
    }
}