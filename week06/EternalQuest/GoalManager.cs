using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private List<string> _badges = new List<string>();
    private int _score = 0;
    private int _level = 1;

    public void CreateGoal()
    {
        Console.WriteLine("Choose a goal type: 1=Simple, 2=Eternal, 3=Checklist");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
        
        }
    }

    public void RecordEvent()
    {
        
        Console.Write("Which goal number did you complete? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent(ref _score);
            CheckLevelUp();
            CheckBadges();
            Console.WriteLine("Updated Goal Status");
            Console.WriteLine($"{index + 1}. {_goals[index].DisplayStatus()}");
        }
    }

    private void CheckLevelUp()
    {
        int newLevel = (_score / 1000) + 1;
        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($"🎉 Congratulations!! You leveled up to level {_level}");
        }
    }

    private void CheckBadges()
    {
        if (_score >= 5000 && !_badges.Contains("Persistence Badge"))
        {
            _badges.Add("Persistence Badge");
            Console.WriteLine("🏅 You earned the Persistence Badge for reaching 5000 points");
        }
        if (_goals.Count >= 10 && !_badges.Contains("Goal Setter Badge"))
        {
            _badges.Add("Goal Setter Badge");
            Console.WriteLine("🏅 You eanred the Goal Setter Badge for creating 10 goals!");
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].DisplayStatus()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine($"Current Level: {_level}");
        if (_badges.Count > 0)
        {
            Console.WriteLine("Badges Earned: " + string.Join(',', _badges));
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            writer.WriteLine(_level);
            writer.WriteLine(string.Join(",", _badges));
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.DisplayStatus());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            _score = int.Parse(lines[0]);
            _level = int.Parse(lines[1]);
            _badges = new List<string>(lines[2].Split(",", StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine("Goals loaded.");
        }
    }
} 

        