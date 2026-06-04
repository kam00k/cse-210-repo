//Jack Wilson
//CSE 210
//Final Project Program 4

public class ActivityList
{
    //list of Activity objects
    private List<Activity> _activityList;

    //Constructor. Instantiates the activity list.
    public ActivityList()
    {
        _activityList = new List<Activity>();
    }

    //method for adding Activities to the list.
    public void AddActivity(string type, string date, int length, int third)
    {
        if (type == "Running")
        {
            _activityList.Add(new Running(date, length, third));    
        }
        else if (type == "Cycling")
        {
            _activityList.Add(new Cycling(date, length, third));    
        }
        else if (type == "Swimming")
        {
            _activityList.Add(new Swimming(date, length, third));    
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

    //Method for displaying the activities in the list.
    public void ShowActivities()
    {
        Console.WriteLine("\nMy Activities\n");

        foreach (var activity in _activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}