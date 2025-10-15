// Represents a goal that is never complete but provides points each time it's recorded.
public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }


    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return int.Parse(_points);
    }


    public override string GetStringRepresentation() // For saving to a file
    {
        return $"EternalGoal:{_shortName}, {_description}, {_points}";
    }
}