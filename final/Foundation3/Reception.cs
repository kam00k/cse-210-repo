public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, string rsvp) : base(title, description, date, time)
    {
        _rsvpEmail = rsvp;
    }

    public void FullDescription()
    {
        StandardDescription();
        Console.WriteLine($"Please RSVP at the email below to save your spot at this event.");
        Console.WriteLine(_rsvpEmail);
    }

    public void ShortDescription()
    {
        Console.WriteLine($"\nEvent: Reception\nTitle: {_title}\nDate: {_date}\n");
    }
}