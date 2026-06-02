public class Swimming : Activity
{
    private double _numOfLaps;

    public Swimming(string date, double length, double numLaps) : base(date, length)
    {
        _numOfLaps = numLaps;
        _activityType = "Swimming";
    }

    public override double GetDistance()
    {
        return (_numOfLaps * 50 / 1000);
    }

    public override double GetSpeed()
    {
        return ((GetDistance() / _length) * 60);
    }

    public override double GetPace()
    {
        return ((60 / GetSpeed()));
    }
}