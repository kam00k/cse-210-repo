//Jack Wilson
//CSE 210
//Final Project Program 4

public class Cycling : Activity
{
    //subclass-specific attribute
    private double _speed;

    //Constructor. Populates the activity type and the subclass attribute.
    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
        _activityType = "Cycling";
    }

    //Overridden getter methods.
    public override double GetDistance()
    {
        return _speed * _length / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return (60 / GetSpeed());
    }
}