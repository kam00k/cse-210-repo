public class Activity
{
    protected string _date;
    protected int _length;

    protected string _activityType;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return ($"{_date} {_activityType} ({_length} min)- Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}");
    }
}