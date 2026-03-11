using System;
class EternalGoal : Goal
{
    public EternalGoal(int points, string name, string description) : base(points, name, description)
    {        
    }
    // My Special Methods :D
    public override void CompleteGoal()
    {
        
    }
    public override string DisplayGoalStats()
    {
        string s = $"[N/A] {GetName()} ({GetDescription()})";
        return s;
    }
    public override string SaveGoalStats()
    {
        string s = $"EternalGoal~|~{GetPoints()}~|~{GetName()}~|~{GetDescription()}";
        return s;
    }
}