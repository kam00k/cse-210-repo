class ListingActivity : Activity
{
    private int _entryCounter;

    public ListingActivity(int duration)
    {
        _name = "Listing Activity";
        _description = "This activity will help you to relax and calm your mind through a controlled breathing exercise.";
        _duration = duration;
        _entryCounter = 0;

        _promptList.Add("Think of a time when you stood up for someone else.");
        _promptList.Add("Think of a time when you did something really difficult.");
        _promptList.Add("Think of a time when you helped someone in need.");
        _promptList.Add("Think of a time when you did something truly selfless.");
    }

    public void ListingLoop()
    {
        
    }
    
}