using System;

public class Variable
{
    private char _letter;
    public Variable(char letter)
    {
        _letter = letter;
    }

    public char GetLetter()
    {
        return _letter;
    }

}