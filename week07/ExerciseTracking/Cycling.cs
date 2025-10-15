public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double timeInHours = GetLengthInMinutes() / 60.0; // Convert minutes to hours
        return _speed * timeInHours; // Distance in km
    }

    public override double GetSpeed()
    {
        return _speed; // Speed in kph
    }

    public override double GetPace()
    {
        return 60 / _speed; // Pace in minutes per km
    } 
}