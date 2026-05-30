class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected List<string> _promptList = new List<string>();
    protected Random _rand = new Random();


    public void Spin(int rounds)
    {
        string[] whirly = {"-", "\\", "|", "/"};
        for (int i = 0; i < rounds; i++)
        {
            foreach (var thing in whirly)
            {
                Console.Write(thing);
                Thread.Sleep(125);
                Console.Write("\b \b");
            }
        }
    }

    public void Ellipsis(int rounds)
    {
        for (int i = 0; i < rounds; i++)
        {
            Console.Write(". ");
            Thread.Sleep(250);
            Console.Write(". ");
            Thread.Sleep(250);
            Console.Write(". ");
            Thread.Sleep(250);
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new String(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(250);
        }
    }

    public void Countdown(int duration)
    {
        Console.Write(duration);
        Thread.Sleep(1000);
        for(int i = duration-1; i > 0; i--)
        {
            
            Console.Write("\b \b");
            Console.Write(i);
            Thread.Sleep(1000);
        }
        Console.Write("\b \b");
        Console.Write("0\n");
    }

    public void EndMessage()
    {
        Console.WriteLine("\nWell done! We hope this activity helped you to relax and increase your mindfulness and positivity.\n");
    }

}