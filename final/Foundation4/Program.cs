using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();

        activityList.Add(new Running("23 Dec 2018", 120, 12));
        activityList.Add(new Cycling("2 April 2022", 60, 35));
        activityList.Add(new Swimming("20 June 2026", 15, 5));

        foreach (var activity in activityList)
        {
            activity.GetSummary();
        }


    }
}