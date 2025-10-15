using System.Runtime.InteropServices;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Constructor for loading from a file
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }


    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return int.Parse(_points);
        }
        Console.WriteLine("Goal has been completed already.");
        return 0;
    }

    
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName}, {_description}, {_points}, {_isComplete}";
    }
}