//Jack Wilson
//CSE 210
//Final Project, Program 3
public class Lecture : Event
{
    //Lecture-specific attributes
    private string _speakerName;
    private int _capacity;


    //Constructor. Calls the base constructor and sets its own attributes based on the last two parameters.
    public Lecture(string title, string description, string date, string time, string speaker, int capacity) : base(title, description, date, time)
    {
        _speakerName = speaker;
        _capacity = capacity;
    }

    //Lecture-specific version of the full description method
    public void FullDescription()
    {
        StandardDescription();
        Console.WriteLine($"Guests will have the opportunity to hear from {_speakerName}");
        Console.WriteLine($"Due to building and fire code constraints, this lecture is limited to {_capacity} attendees,");
        Console.WriteLine("Please plan on arriving early if you wish to secure a seat.\n");
    }

    //Lecture-specific version of the short description method
    public void ShortDescription()
    {
        Console.WriteLine($"\nEvent: Lecture\nTitle: {_title}\nDate: {_date}\n");
    }
}