using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }
    
    public override void RecordEvent(ref int score)
    {
        score += _points;
        Console.WriteLine($"Recorded {_name}! +{_points} points");
    }

    public override string DisplayStatus()
    {
        return $"[∞] {_name}";
    }
}