using System;
class ChecklistGoal : Goal
{
    private int _progressGoal;
    private int _currentProgress = 0;
    private int _bonusPoints;

    // Constructors
    public ChecklistGoal(int points, string name, string description, int progressGoal, int bonusPoints) : base(points, name, description)
    {
        _progressGoal = progressGoal;
        _bonusPoints = bonusPoints;
    }
    public ChecklistGoal(int points, string name, string description, int progressGoal, int bonusPoints, int currentProgress) : base(points, name, description)
    {
        _progressGoal = progressGoal;
        _bonusPoints = bonusPoints;
        _currentProgress = currentProgress;
    }

    // Methods
    public int GetProgressGoal()
    {
        return _progressGoal;
    }
    public int GetCurrentProgress()
    {
        return _currentProgress;
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    // My Special Methods :D
    public override int CompleteGoal()
    {
        _currentProgress++;
        if (_currentProgress == _progressGoal)
        {
            return GetPoints() + GetBonusPoints();
        }
        else
        {
            return GetPoints();
        }
    }
    public override string DisplayGoalStats()
    {
        string status = " ";
        if (_currentProgress >= _progressGoal)
        {
            status = "X";
        }
        string s = $"[{status}] {GetName()} ({GetDescription()}) -- Currently completed {_currentProgress}/{_progressGoal}";
        return s;
    }
    public override string SaveGoalStats()
    {
        // int points, string name, string description, int progressGoal, int bonusPoints, int currentProgress
        string s = $"ChecklistGoal~|~{GetPoints()}~|~{GetName()}~|~{GetDescription()}~|~{GetProgressGoal()}~|~{GetBonusPoints()}~|~{GetCurrentProgress()}";
        return s;
    }
}