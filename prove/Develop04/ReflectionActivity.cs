//Jack Wilson
//CSE 210
//W04 Develop Project

class ReflectionActivity : Activity
{
    //reflection list. This contains all the reflection questions. 
    //This is contained in this subclass because only it requires
    //a second list of strings.
    private List<string> _reflectionList = new List<string>();

    //Constructor. Populates the name and description attributes, as well as the _promptList and _reflectionList. 
    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you to think positively by having you recall times of growth from your past and ponder them.";

        _promptList.Add("Think of a time when you helped someone out of trouble");
        _promptList.Add("Think of a time when you pushed your limits.");
        _promptList.Add("Think of a time when someone confided in you.");
        _promptList.Add("Think of a time when your values were challenged.");

        _reflectionList.Add("Why was this experience meaningful to you?");
        _reflectionList.Add("Have you ever done anything like this before?");
        _reflectionList.Add("How was your perspective changed by this?");
        _reflectionList.Add("How did you feel afterwards?");
        _reflectionList.Add("What made this experience stand out to you?");
        _reflectionList.Add("If you could relive this same event again, what would you do differently?");
        _reflectionList.Add("How could you apply what you have learned from this experience to your daily life?");
        _reflectionList.Add("Did you learn anything new about yourself?");
        _reflectionList.Add("Is this something you would like to experience again?");
    }

    public void ReflectionLoop()
    {
        //Clear the terminal and display the name and description
        Console.Clear();
        Console.WriteLine(_name);
        Console.WriteLine(_description);

        //Get the desired activity duration from the user and assign it to _duration
        Console.WriteLine("Please enter how long you would like to do this activity for (in seconds):");
        _duration = Convert.ToInt32(Console.ReadLine());

        //Create some DateTime objects to keep track of the time.
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;

        //Randomly select a prompt from _promptList and display it.
        int promptRandInt = _rand.Next(0, _promptList.Count());
        Console.WriteLine("\n" + _promptList[promptRandInt] + "\n");

        //Until the timer runs out,
        while (currentTime < stopTime)
        {
            //Display a new Reflection for every iteration of this loop
            int reflectionRandInt = _rand.Next(0, _reflectionList.Count());
            Console.WriteLine(_reflectionList[reflectionRandInt]);
            //Run the spin animation, then update the currentTime object.
            Spin(12);
            currentTime = DateTime.Now;
        }

        //Display the standard ending message at the end of the activity.
        EndMessage();
    }
}