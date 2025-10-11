public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"Recorded '{_shortName}' ({_amountCompleted}/{_target}) +{_points} points");

            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Checklist completed! Bonus +{_bonus} points");
            }
        }
        else
        {
            Console.WriteLine($"'{_shortName}' checklist already completed.");
        }
    }

    public override bool isCompleted() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - Progress: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}
