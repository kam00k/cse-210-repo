class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected List<string> _promptList;
    protected Random _rand;


    public void Spin()
    {
        
    }

    public void Ellipsis()
    {
        
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