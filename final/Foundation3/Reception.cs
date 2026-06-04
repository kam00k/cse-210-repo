//Jack Wilson
//CSE 210
//Final Project, Program 3

public class Reception : Event
{
    //Reception-specific attribute
    private string _rsvpEmail;

    //Constructor. Calls the base constructor and sets its own attributes based on the last parameter
    public Reception(string title, string description, string date, string time, string rsvp) : base(title, description, date, time)
    {
        _rsvpEmail = rsvp;
    }

    //Reception-specific version of the full description method
    public void FullDescription()
    {
        StandardDescription();
        Console.WriteLine($"Please RSVP at the email below to save your spot at this event.");
        Console.WriteLine(_rsvpEmail);
    }

    //Reception-specific version of the short description method
    public void ShortDescription()
    {
        Console.WriteLine($"\nEvent: Reception\nTitle: {_title}\nDate: {_date}\n");
    }
}