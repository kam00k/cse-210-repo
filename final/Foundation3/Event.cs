//Jack Wilson
//CSE 210
//Final Project, Program 3

public class Event
{
    //Event base attributes
    protected string _title;
    protected string _description;

    protected string _date;

    protected string _time;

    protected Address _address;

    //Base constructor, assigns attributes by parameters.
    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
    }

    //Outputs the standard description to the console.
    public void StandardDescription()
    {
        Console.WriteLine("\nYou are cordially invited to");
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine($"Address: {_address.GetAddressString()}");
        Console.WriteLine($"This event takes place on {_date} at {_time}.");
    }

    //sets the address attribute to a new Address object with its own attributes passed in.
    public void SetAddress(string address, string city, string state, string zip)
    {
        _address = new Address(address, city, state, zip);
    }
}