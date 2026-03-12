using System;
class SimpleGoal : Goal
{
    bool isCompleted = false;
    public SimpleGoal(int points, string name, string description) : base(points, name, description)
    {        
    }
    // My Special Methods :D
    public override int CompleteGoal()
    {
        isCompleted = true;
        return GetPoints();
    }
    public override string DisplayGoalStats()
    {
        string v = " ";
        if (isCompleted)
        {
            v = "X";
        }
        string s = $"[{v}] {GetName()} ({GetDescription()})";
        return s;
    }
    public override string SaveGoalStats()
    {
        string s = $"SimpleGoal~|~{GetPoints()}~|~{GetName()}~|~{GetDescription()}~|~{isCompleted}";
        return s;
    }
}