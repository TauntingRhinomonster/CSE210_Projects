using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

public class Equation
{
    private List<Term> _equation = new();
    public int TermCount => _equation.Count;

    public Equation()
    {
    }
    // General Methods :|
    public List<Term> GetTerms()
    {
        return _equation;
    }

    // My Special Methods :D
    public void AddTerm(Term term)
    {
        if (term != null)
        {
            _equation.Add(term);
        }
    }
    public string Display()
    {
        List<string> termStrings = new List<string>();

        foreach (Term term in _equation)
        {
            termStrings.Add(term.Display());
        }

        return string.Join(" + ", termStrings);
    }
}