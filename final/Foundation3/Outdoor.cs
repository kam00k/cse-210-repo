public class Outdoor : Event
{
    private string _weatherStatement;


    public Outdoor(string title, string description, string date, string time, string weather) : base(title, description, date, time)
    {
        _weatherStatement = weather;
    }

    public void FullDescription()
    {
        StandardDescription();
        Console.WriteLine(_weatherStatement);
    }

    public void ShortDescription()
    {
        Console.WriteLine($"\nEvent: Outdoor Gathering\nTitle: {_title}\nDate: {_date}");
    }
}