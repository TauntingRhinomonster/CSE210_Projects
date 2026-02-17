using System;

class Assignment
{
    // Variables
    private string _studentName;
    private string _topic;
    // Constructors
    public Assignment()
    {
        _studentName = "John Doe";
        _topic = "Multiplication";
    }
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    // Methods
    public string GetName()
    {
        return _studentName;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}