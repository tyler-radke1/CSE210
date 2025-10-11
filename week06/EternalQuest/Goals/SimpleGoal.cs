public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, string points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"You completed '{_shortName}'! +{_points} points");
        }
        else
        {
            Console.WriteLine($"'{_shortName}' is already completed.");
        }
    }

    public override bool isCompleted() => _isComplete;

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - Completed: {_isComplete}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}