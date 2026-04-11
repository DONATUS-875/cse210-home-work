using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
    }

    public override void RecordEvent(ref int score)
    {
        _currentCount++;
        score += _points;
        Console.WriteLine($"Progressed {_name}: {_currentCount}/{_targetCount} (+{_points} points)");

        if (_currentCount == _targetCount)
        {
            score += _bonus;
            Console.WriteLine($"Checklist complete!! Bonus +{_bonus} points");
        }
    }

    public override string DisplayStatus()
    {
        string status = _currentCount >= _targetCount ? "[X]" : "[ ]";
        return $"{status} {_name} (Completed {_currentCount}/{_targetCount})";
    }
}
