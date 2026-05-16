class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected List<string> _promptList = new List<string>();
    protected Random _rand;


    public void Spin()
    {
        string[] whirly = {"-", "\\", "|", "/"};
        foreach (var thing in whirly)
        {
            Console.Write(thing);
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
    }

    public void Ellipsis()
    {
        Console.Write(". ");
        Thread.Sleep(400);
        Console.Write(". ");
        Thread.Sleep(400);
        Console.Write(". ");
        Thread.Sleep(400);
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new String(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, Console.CursorTop);
        Thread.Sleep(400);
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
        Console.Write(0);
    }


}