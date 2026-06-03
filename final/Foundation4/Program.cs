
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();

        Console.WriteLine("\nMy Activities\n");
        
        activityList.Add(new Running("23 Dec 2018", 120, 12));
        activityList.Add(new Cycling("2 April 2022", 95, 35));
        activityList.Add(new Swimming("20 June 2026", 15, 7));

        foreach (var activity in activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }


    }
}