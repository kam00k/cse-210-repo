public class Swimming : Activity
{
    private double _numOfLaps;

    public Swimming(string date, int length, double numLaps) : base(date, length)
    {
        _numOfLaps = numLaps;
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