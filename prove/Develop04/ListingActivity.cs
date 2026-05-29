class ListingActivity : Activity
{
    private int _entryCounter;

    public ListingActivity(int duration)
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = duration;
        _entryCounter = 0;

        _promptList.Add("Who are people that you appreciate?");
        _promptList.Add("What are personal strengths of yours?");
        _promptList.Add("Who are people that you have helped this week?");
        _promptList.Add("When have you felt the Holy Ghost this month?");
        _promptList.Add("Who are some of your personal heroes?");
    }

    public void ListingLoop()
    {
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;

        int randInt = _rand.Next(0, _promptList.Count());

        Console.WriteLine("Think about the following prompt until the countdown ends, and then start writing your answers to the prompt. Press Enter after each answer.");
        Console.WriteLine(_promptList[randInt]);
        Countdown(5);

        while (currentTime < stopTime)
        {
            Console.ReadLine();
            _entryCounter += 1;
            currentTime = DateTime.Now;
        }
    }
}