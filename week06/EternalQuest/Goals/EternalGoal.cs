public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"You recorded '{_shortName}'! +{_points} points");
    }

    public override bool isCompleted() => false; // Never complete

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - Always ongoing";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}