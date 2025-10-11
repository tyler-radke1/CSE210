using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
        Console.WriteLine($"Total Goals: {_goals.Count}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select goal type: 1. Simple 2. Eternal 3. Checklist");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        string points = Console.ReadLine();

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    // Record an event for a goal
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        Console.WriteLine("Select goal number to record:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();

            _score += int.TryParse((_goals[index] as dynamic)._points, out int pts) ? pts : 0;

            if (_goals[index] is ChecklistGoal checklist && checklist.isCompleted())
            {
                _score += (checklist as dynamic)._bonus;
            }
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoalsJson()
{
    var options = new JsonSerializerOptions
    {
        WriteIndented = true, // nice formatting
        Converters = { new GoalJsonConverter() }
    };

    var data = new GoalManagerData
    {
        Score = _score,
        Goals = _goals
    };

    string json = JsonSerializer.Serialize(data, options);
    File.WriteAllText("goals.json", json);

    Console.WriteLine("Goals saved to JSON!");
}

public void LoadGoalsJson()
{
    if (!File.Exists("goals.json"))
    {
        Console.WriteLine("No saved goals found.");
        return;
    }

    string json = File.ReadAllText("goals.json");

    var options = new JsonSerializerOptions
    {
        Converters = { new GoalJsonConverter() }
    };

    var data = JsonSerializer.Deserialize<GoalManagerData>(json, options);

    _score = data.Score;
    _goals = data.Goals ?? new List<Goal>();

    Console.WriteLine("Goals loaded from JSON!");
}
}
