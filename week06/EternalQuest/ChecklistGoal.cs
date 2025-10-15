// Represents a goal that needs to be accomplished multiple times.
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    //Constructor for loading from a file
    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override bool IsComplete() {
        return _amountCompleted >= _target; // Checklist goal is complete when amount completed meets or exceeds target
     }
    

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++; // Increment the count of completed tasks
            if (IsComplete())
            {
                Console.WriteLine($"Congratulations! You have completed the checklist and earned {_points} points plus a bonus of {_bonus} points!");
                return int.Parse(_points) + _bonus;
            }
            else
            {
                Console.WriteLine($"Congratulations! You have earned {_points} points!");
                return int.Parse(_points);
            }
        }
        Console.WriteLine("This goal is completed already.");
        return 0;
    }


    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName}, {_description}, {_points}, {_target}, {_bonus}, {_amountCompleted}";
    }
}