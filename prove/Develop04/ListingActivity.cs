//Jack Wilson
//CSE 210
//W04 Develop Project

class ListingActivity : Activity
{
    //Attribute to keep track of how many entries are made by the user in this activity.
    private int _entryCounter;

    //Constructor. Populates the _name and _description attributes and initializes _entryCounter. 
    // Also populates the _promptList with prompts specific to this activity. 
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you to realize the good things about you by having you list them according to a prompt.";
        _entryCounter = 0;

        _promptList.Add("Who are the people you are closest to?");
        _promptList.Add("What dreams for the future do you have?");
        _promptList.Add("How were you able to serve someone this week?");
        _promptList.Add("What have you felt inspired to do over the past month?");
        _promptList.Add("Who are some of your relatives or ancestors you have heard interesting stories about?");
    }

    public void ListingLoop()
    {
        //Clear the terminal and display the name and description
        Console.Clear();
        Console.WriteLine(_name);
        Console.WriteLine(_description);

        //Get the desired duration from the user and assign it to _duration.
        Console.WriteLine("Please enter how long you would like to do this activity for (in seconds):");
        _duration = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
        Console.WriteLine(_name);
        Console.WriteLine(_description);

        //Create some DateTime objects to keep track of the time.
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;

        //Pick a random prompt from the list, display instructions to the user and start a preparation countdown.
        int randInt = _rand.Next(0, _promptList.Count());
        Console.WriteLine("\nThink about the following prompt until the countdown ends, and then start writing your answers to the prompt. Press Enter after each answer.");
        Console.WriteLine("\n"+_promptList[randInt]+"\n");
        Countdown(5);
        Console.Write("\b \b");
        Console.Write("Go!\n\n");

        //Read inputs from the user and increment the entry counter each time, until the timer runs out.
        while (currentTime < stopTime)
        {
            Console.ReadLine();
            _entryCounter += 1;
            currentTime = DateTime.Now;
        }

        //Display the number of entries written by the user, followed by the end message.
        Console.WriteLine($"\nYou wrote out {_entryCounter} answer(s) to the prompt!");
        EndMessage();
    }
}