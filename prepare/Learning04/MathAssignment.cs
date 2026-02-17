using System;

class MathAssignment : Assignment
{
    // Variables
    private string _textBookSection;
    private string _problems;
    // Constructors
    public MathAssignment() : base()
    {
        
    }
    public MathAssignment(string name, string topic, string textBookSection, string problems) : base(name, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }
    // Methods
    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}