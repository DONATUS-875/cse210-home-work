using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent(ref int score)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            score += _points;
            Console.WriteLine($"Completed {_name} +{_points} points");
        }
        else
        {
            Console.WriteLine($"{_name} is already complete.");
        }
    }

    public override string DisplayStatus()
    {
        return _isComplete ? $"[X] {_name}" : $"[ ] {_name}";
    }
}
    
    
