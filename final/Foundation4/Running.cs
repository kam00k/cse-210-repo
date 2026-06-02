public class Running : Activity
{
    private double _distance;

    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
        _activityType = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return ((_distance / _length) * 60);
    }

    public override double GetPace()
    {
        return (60 / GetSpeed());
    }
}