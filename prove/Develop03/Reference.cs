using System;

class Reference
{
    // Variables
    string _wholeRef;
    // Constructors
    public Reference(string bookName, int chapterNum, int verseStart)
    {
        _wholeRef = $"{bookName} {chapterNum}:{verseStart}";
    }
    public Reference(string bookName, int chapterNum, int verseStart, int verseEnd)
    {
        _wholeRef = $"{bookName} {chapterNum}:{verseStart}-{verseEnd}";
    }
    public Reference(int bookNum, string bookName, int chapterNum, int verseStart)
    {
        _wholeRef = $"{bookNum} {bookName} {chapterNum}:{verseStart}";
    }
    public Reference(int bookNum, string bookName, int chapterNum, int verseStart, int verseEnd)
    {
        _wholeRef = $"{bookNum} {bookName} {chapterNum}:{verseStart}-{verseEnd}";
    }
    // Methods
    public string GetReferenceString()
    {
        return _wholeRef;
    }
}