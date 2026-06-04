//Jack Wilson
//CSE 210
//Final Project, Program 3

public class Outdoor : Event
{
    //Outdoor-specific attribute
    private string _weatherStatement;
       
    //Constructor. Calls the base constructor and sets its own attributes based on the last parameter
    public Outdoor(string title, string description, string date, string time, string weather) : base(title, description, date, time)
    {
        _weatherStatement = weather;
    }
    
    //Outdoor-specific version of the full description method
    public void FullDescription()
    {
        StandardDescription();
        Console.WriteLine(_weatherStatement);
    }

    //Outdoor-specific version of the short description method
    public void ShortDescription()
    {
        Console.WriteLine($"\nEvent: Outdoor Gathering\nTitle: {_title}\nDate: {_date}");
    }
}