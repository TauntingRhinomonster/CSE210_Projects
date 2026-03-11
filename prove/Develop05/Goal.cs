using System;
abstract class Goal
{
    private int _points;
    private string _name;
    private string _description;

    // Constructors
    public Goal(int points, string name, string description)
    {
        _points = points;
        _name = name;
        _description = description;
    }

    // Methods
    public int GetPoints()
    {
        return _points;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    // My Special Method :D
    public abstract void CompleteGoal();
    public abstract string DisplayGoalStats();
    public abstract string SaveGoalStats();
    public void DisplayScore()
    {
        Console.WriteLine($"Points: {GetPoints()}");
    }
}