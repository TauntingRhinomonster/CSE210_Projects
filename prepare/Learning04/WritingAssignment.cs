using System;

class WritingAssignment : Assignment
{
    // Variables
    private string _title;
    // Constructors
    public WritingAssignment() : base()
    {
        
    }
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }
    // Methods
    public string GetWritingInfo()
    {
        return $"{_title} by {GetName()}";
    }
}