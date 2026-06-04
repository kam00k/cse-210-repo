//Jack Wilson
//CSE 210
//W04 Develop Project

public class ActivityHistory
{
    //Counters for each type of activity.
    private int _breathingCounter;
    private int _reflectionCounter;
    private int _listingCounter;

    //Constructor. Initializes each counter to zero.
    public ActivityHistory()
    {
        _breathingCounter = 0;
        _reflectionCounter = 0;
        _listingCounter = 0;
    }

    //Sets a different history counter depending on the passed parameter.
    public void SetHistory(int type)
    {
        if (type == 0)
        {
            _breathingCounter += 1;
        }
        else if (type == 1)
        {
            _reflectionCounter += 1;
        }
        else if (type == 2)
        {
            _listingCounter += 1;
        }

        //Only 0, 1 and 2 are acceptable parameters in this version of the method.
        else
        {
            Console.WriteLine("You have an incorrect SetHistory call somewhere.");
        }
    }

    public void GetHistory()
    {
        //clear the console, display the count of each activity performed this session,
        //and then wait for the user to press a key to return to the main menu.
        Console.Clear();
        Console.WriteLine($"\nYour activity history is as follows:");
        Console.WriteLine($"Breathing activities performed: {_breathingCounter}");
        Console.WriteLine($"Reflection activities performed: {_reflectionCounter}");
        Console.WriteLine($"Listing activities performed: {_listingCounter}\n");
        Console.WriteLine("Press any key to return...");
        Console.ReadLine();
    }
}