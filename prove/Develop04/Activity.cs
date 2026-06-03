//Jack Wilson
//CSE 210
//W04 Develop Project

class Activity
{   
    //Base attributes of the activity class.
    protected string _name;
    protected string _description;
    protected int _duration;
    protected List<string> _promptList = new List<string>();

    //This will be used by subclasses to randomly select from lists associated with them.
    protected Random _rand = new Random();


    //Spin animation, runs for the given number of rotations. Each rotation takes about half a second.
    public void Spin(int rounds)
    {
        //Create a string array that will contain the characters needed for a spinning line
        string[] whirly = {"-", "\\", "|", "/"};

        //For as many times as the rounds parameter says,
        for (int i = 0; i < rounds; i++)
        {
            //Loop through the string array, displaying and deleting each character in turn
            //to create the animation.
            foreach (var thing in whirly)
            {
                Console.Write(thing);
                Thread.Sleep(125);
                Console.Write("\b \b");
            }
        }
    }

    //Ellipsis animation. Similarly runs according to rounds given rather than seconds.
    public void Ellipsis(int rounds)
    {   
        //For each round of the animation
        for (int i = 0; i < rounds; i++)
        {
            //write a dot every 250ms
            Console.Write(". ");
            Thread.Sleep(250);
            Console.Write(". ");
            Thread.Sleep(250);
            Console.Write(". ");
            Thread.Sleep(250);

            //erase the entire line and set the cursor to the beginning of the line.
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new String(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(250);

            //this works out to about one ellipsis per second.
        }
    }

    //countdown method (duration in seconds)
    public void Countdown(int duration)
    {
        //display the initial duration number, then sleep for one second.
        Console.Write(duration);
        Thread.Sleep(1000);

        //For as many seconds as have been given, decrement i
        for(int i = duration-1; i > 0; i--)
        {
            
            //erase the number (can go up to 9999 seconds without problems)
            Console.Write("\b\b\b   \b\b\b");
            Console.Write(i);
            Thread.Sleep(1000);
        }
        //erase the last number (which by this point will be only a single digit)
        //and replace it with zero. 
        Console.Write("\b \b");
        Console.Write("0");
    }

    //print a standard end message, displayed for three seconds before going back to the main menu.
    //to be called at the end of every activity.
    public void EndMessage()
    {
        Console.WriteLine("\nWell done! We hope this activity helped you to relax and increase your mindfulness and positivity.\n");
        Thread.Sleep(3000);
    }

}