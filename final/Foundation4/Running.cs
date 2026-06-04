//Jack Wilson
//CSE 210
//Final Project Program 4

public class Running : Activity
{
    //subclass-specific attribute
    private double _distance;

    //Constructor. Populates the activity type and the subclass attribute.
    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
        _activityType = "Running";
    }

    //Overridden getter methods.
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