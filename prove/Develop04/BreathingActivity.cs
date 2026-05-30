class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you to relax and calm your mind through a controlled breathing exercise.";
    }

    public void BreathingLoop()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_description);

        Console.WriteLine("Please enter how long you would like to do this activity for (in seconds):");
        _duration = Convert.ToInt32(Console.ReadLine());

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;

        while (currentTime < stopTime)
        {
            Console.Clear();
            Console.WriteLine(_name);
            Console.WriteLine(_description);

            Console.WriteLine("Breathe in...");
            Countdown(5);

            Console.Clear();
            Console.WriteLine(_name);
            Console.WriteLine(_description);

            Console.WriteLine("Breathe out...");
            Countdown(5);
            currentTime = DateTime.Now;
        }
        EndMessage();
    }
}