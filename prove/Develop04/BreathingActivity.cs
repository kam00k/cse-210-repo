//Jack Wilson
//CSE 210
//W04 Develop Project

class BreathingActivity : Activity
{

    //Constructor. Populates the name and description attributes. The _duration attribute will be assigned after construction.
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you to relax and calm your mind through a controlled breathing exercise.";
    }

    //This method represents the actual activity, i.e. the "gameplay" portion. 
    public void BreathingLoop()
    {
        //Clear the terminal and display the name and description
        Console.Clear();
        Console.WriteLine(_name);
        Console.WriteLine(_description);

        //Ask for the desired duration from the user and assign it to duration.
        Console.WriteLine("Please enter how long you would like to do this activity for (in seconds):");
        _duration = Convert.ToInt32(Console.ReadLine());

        //Create some DateTime objects to keep track of the time.
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;

        //Until the time runs out,
        while (currentTime < stopTime)
        {
            //Clear the terminal and rewrite the name and description.
            Console.Clear();
            Console.WriteLine(_name);
            Console.WriteLine(_description);

            //Alternate between breathing in and breathing out, clearing and replacing 
            //the name and description each time.
            Console.WriteLine("Breathe in...");
            Countdown(5);

            Console.Clear();
            Console.WriteLine(_name);
            Console.WriteLine(_description);

            Console.WriteLine("Breathe out...");
            Countdown(5);

            //update the currentTime object to reflect the actual current time.
            currentTime = DateTime.Now;
        }

        //Display the ending message.
        EndMessage();
    }
}