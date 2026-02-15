using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _text; 

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = new List<Word>(); 
        CreateWordsList(text);
    }

    private void CreateWordsList(string text)
    {
        List<string> strings = text.Split(" ").ToList();
        foreach (string wordString in strings)
        {
            _text.Add(new Word(wordString));
        }
    }

    public void ReprintScripture()
    {
        Console.WriteLine(_reference.GetReferenceString());

        foreach (Word word in _text)
        {
            Console.Write(word.GetWord() + " ");
        }
        Console.WriteLine(); 
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHiddenCount = 0;
        
        while (wordsHiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int index = random.Next(_text.Count);
            
            if (!_text[index].IsHidden())
            {
                _text[index].HideWord();
                wordsHiddenCount++;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _text)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}