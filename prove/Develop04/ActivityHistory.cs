//Jack Wilson
//CSE 210
//W04 Develop Project

public class ActivityHistory
{
    private int _breathingCounter;
    private int _reflectionCounter;

    private int _listingCounter;

    public ActivityHistory()
    {
        _breathingCounter = 0;
        _reflectionCounter = 0;
        _listingCounter = 0;
    }

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
    }

    public void GetHistory()
    {
        Console.Clear();
        Console.WriteLine($"\nYour activity history is as follows:");
        Console.WriteLine($"Breathing activities performed: {_breathingCounter}");
        Console.WriteLine($"Reflection activities performed: {_reflectionCounter}");
        Console.WriteLine($"Listing activities performed: {_listingCounter}\n");
        Console.WriteLine("Press any key to return...");
        Console.ReadLine();
    }
}