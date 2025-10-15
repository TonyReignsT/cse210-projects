using System.Diagnostics;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public int GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed(); // implemented in derived classes
    public abstract double GetPace();  // implemented in derived classes

    public string GetSummary()
    {
        string activityType = GetType().Name;
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        string date = _date.ToString("MM/dd/yyyy");

        return $"{date} {activityType} ({_lengthInMinutes} Min) - Distance {distance} Km, Speed: {speed} kph, Pace: {pace} min per km";
    }
}