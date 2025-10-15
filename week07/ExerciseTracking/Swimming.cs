public class Swimming : Activity
{
    private int _laps;
    private const double lapLengthInKm = 0.05; // Each lap is 50 meters or 0.05 kilometers

    public Swimming(DateTime date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * lapLengthInKm; // Distance in km
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / GetLengthInMinutes()) * 60; // Speed in kph
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return GetLengthInMinutes() / distance; // Pace in minutes per km
    }
}