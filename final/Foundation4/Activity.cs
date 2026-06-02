public class Activity
{
    protected string _date;
    protected double _length;

    protected string _activityType;

    public Activity(string date, double length)
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
        return ($"{_date} {_activityType} ({_length} min)- Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2}km/h, Pace: {GetPace():F2} min per km");
    }
}