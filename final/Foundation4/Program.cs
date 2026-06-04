
class Program
{
    static void Main(string[] args)
    {
        //Create an activity list
        ActivityList activityList = new ActivityList();

        //populate the activity list
        activityList.AddActivity("Running","23 Dec 2018", 120, 12);
        activityList.AddActivity("Cycling", "2 April 2022", 95, 35);
        activityList.AddActivity("Swimming", "20 June 2026", 15, 7);

        //show the activity list
        activityList.ShowActivities();
    }
}