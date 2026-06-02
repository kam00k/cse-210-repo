public class Swimming : Activity
{
    private double _numOfLaps;

    public Swimming(string date, int length, double numLaps) : base(date, length)
    {
        _numOfLaps = numLaps;
    }
}