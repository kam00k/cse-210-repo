//Jack Wilson
//CSE 210
//Final Project Program 4

public class Activity
{
    //base class attributes.
    protected string _date;
    protected double _length;

    protected string _activityType;

    //Constructor. Simply populates the first two attributes. The third is populated by the constructors of each subclass.
    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    //Virtual getters
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

    //returns a summary of the activity, based on the attributes and what the various overridden getters calculate.
    public string GetSummary()
    {
        return ($"{_date} {_activityType} ({_length} min)- Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2}km/h, Pace: {GetPace():F2} min per km");
    }
}