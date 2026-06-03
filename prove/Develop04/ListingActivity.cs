//Jack Wilson
//CSE 210
//W04 Develop Project

class ListingActivity : Activity
{
    private int _entryCounter;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you to realize the good things about you by having you list them according to a prompt.";
        _entryCounter = 0;

        _promptList.Add("Who are people that you appreciate?");
        _promptList.Add("What are personal strengths of yours?");
        _promptList.Add("Who are people that you have helped this week?");
        _promptList.Add("When have you felt the Holy Ghost this month?");
        _promptList.Add("Who are some people you look up to?");
    }

    public void ListingLoop()
    {
        Console.WriteLine("Please enter how long you would like to do this activity for (in seconds):");
        _duration = Convert.ToInt32(Console.ReadLine());

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;

        int randInt = _rand.Next(0, _promptList.Count());
        Console.Clear();
        Console.WriteLine("Think about the following prompt until the countdown ends, and then start writing your answers to the prompt. Press Enter after each answer.");
        Console.WriteLine(_promptList[randInt]+"\n");
        Countdown(5);
        Console.Write("\b \b");
        Console.Write("Go!\n\n");

        while (currentTime < stopTime)
        {
            Console.ReadLine();
            _entryCounter += 1;
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"\nYou wrote out {_entryCounter} answer(s) to the prompt!");
        EndMessage();
    }
}