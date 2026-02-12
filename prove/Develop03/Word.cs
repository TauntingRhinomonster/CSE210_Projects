using System;

class Word
{
    // Variables
    private bool _hidden;
    private string _word;
    // Constructors
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    // Methods
    public bool IsHidden()
    {
        return _hidden;
    }
    public string GetWord()
    {
        if (_hidden)
        {
            string blank = "";
            foreach (char i in _word)
            {
                blank += "_";
            }
            return blank;
        }
        else
        {
            return _word;
        }
    }
}