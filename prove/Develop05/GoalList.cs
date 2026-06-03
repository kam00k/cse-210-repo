using System.Diagnostics.Contracts;
using System.IO;
public class GoalList
{
    private List<Goal> _goalList;

    public GoalList()
    {
        _goalList = new List<Goal>();
    }
    
    public void CreateGoal()
    {
        string typeChoice;
        string nameChoice;
        int completionPoints;

        Console.Clear();
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("[1] Simple Goal");
        Console.WriteLine("[2] Eternal Goal");
        Console.WriteLine("[3] Checklist Goal");
        Console.WriteLine("[4] Quit");
        typeChoice = Console.ReadLine();
        
        if (typeChoice == "4")
        {
            return;
        }
        else if (typeChoice != "1" && typeChoice != "2" && typeChoice != "3" && typeChoice != "4")
        {
            Console.WriteLine("Incorrect option. Returning to main menu...");
            Thread.Sleep(1500);
        }
        

        Console.WriteLine("What would you like to name your goal?");
        nameChoice = Console.ReadLine();
        
        Console.WriteLine("How many points will this earn from a single completion?");
        completionPoints = Convert.ToInt32(Console.ReadLine());

        if (typeChoice == "1")
        {
            _goalList.Add(new SimpleGoal("Simple", nameChoice, completionPoints, 0, false));
        }
        else if (typeChoice == "2")
        {
            _goalList.Add(new EternalGoal("Eternal", nameChoice, completionPoints, 0));
        }
        else
        {
            Console.WriteLine("How many repeats would you like to require for full completion of this goal?");
            int bonusThreshold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many bonus points would you like for full completion of this goal?");
            int bonusPoints = Convert.ToInt32(Console.ReadLine());

            _goalList.Add(new ChecklistGoal("Checklist", nameChoice, completionPoints, 0, false, 0, bonusThreshold, bonusPoints));
        }
    }

    public void GetGoalList()
    {
        for (int i = 0; i < _goalList.Count; i++)
        {
            Goal tempGoal = _goalList[i];
            if (tempGoal.GetGoalType() == "Simple")
            {
                Console.WriteLine($"[{tempGoal.IsComplete()}] Simple: {tempGoal.GetName()} | Score: {tempGoal.GetScore()}");  
            }
            else if (tempGoal.GetGoalType() == "Eternal")
            {
                Console.WriteLine($"[{tempGoal.IsComplete()}] Eternal: {tempGoal.GetName()} | Score: {tempGoal.GetScore()}");  
            }
            else if (tempGoal.GetGoalType() == "Checklist")
            {
                Console.WriteLine($"[{tempGoal.IsComplete()}] Checklist: {tempGoal.GetName()} [{tempGoal.GetCompletionRatio()}]  | Score: {tempGoal.GetScore()}");    
            } 
        }
        Console.WriteLine($"Total Score: {GetTotalScore()}");

        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadLine();
    }


    public int GetTotalScore()
    {
        int grandTotal = 0;
        foreach(var goal in _goalList)
        {
            grandTotal += goal.GetScore();
        }
        return grandTotal;
    }


    public void SaveGoalList()
    {
        Console.WriteLine("Enter the filename you would like to save this goal list to:");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var goal in _goalList)
            {
                outputFile.WriteLine(goal.GetGoalString());       
            }            
        }
        Console.WriteLine($"\nFile written successfully!");
        Thread.Sleep(1500);
        
    }

    public void LoadGoalList()
    {
        _goalList.Clear();
        Console.WriteLine("Enter the filename you would like to load the goal list from:");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] strings = line.Split(",");
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i].Trim();
            }
            if (strings.Length == 5)
            {
                _goalList.Add(new SimpleGoal(strings[0], strings[1], Convert.ToInt32(strings[2]), Convert.ToInt32(strings[3]), Convert.ToBoolean(strings[4])));
            }
            else if (strings.Length == 4)
            {
                _goalList.Add(new EternalGoal(strings[0], strings[1], Convert.ToInt32(strings[2]), Convert.ToInt32(strings[3])));
            }
            else if (strings.Length == 8)
            {
                _goalList.Add(new ChecklistGoal(strings[0], strings[1], Convert.ToInt32(strings[2]), Convert.ToInt32(strings[3]), Convert.ToBoolean(strings[4]), Convert.ToInt32(strings[5]), Convert.ToInt32(strings[6]), Convert.ToInt32(strings[7])));
            }
        }
        Console.WriteLine($"\nFile loaded successfully!");
        Thread.Sleep(1500);
    }

    public void Record()
    {
        int recordChoice;

        for (int i = 0; i < _goalList.Count; i++)
        {
            Goal tempGoal = _goalList[i];
            if (tempGoal.GetGoalType() == "Simple")
            {
                Console.WriteLine($"[{i+1}] [{tempGoal.IsComplete()}] Simple: {tempGoal.GetName()} | Score: {tempGoal.GetScore()}");  
            }
            else if (tempGoal.GetGoalType() == "Eternal")
            {
                Console.WriteLine($"[{i+1}] [{tempGoal.IsComplete()}] Eternal: {tempGoal.GetName()} | Score: {tempGoal.GetScore()}");  
            }
            else if (tempGoal.GetGoalType() == "Checklist")
            {
                Console.WriteLine($"[{i+1}] [{tempGoal.IsComplete()}] Checklist: {tempGoal.GetName()} [{tempGoal.GetCompletionRatio()}]  | Score: {tempGoal.GetScore()}");    
            } 
        }
        
        while (true)
        {
            Console.WriteLine("Please select the activity you would like to record to:");
            recordChoice = Convert.ToInt32(Console.ReadLine());

            if (recordChoice > 0 && recordChoice < _goalList.Count+1)
            {
                _goalList[recordChoice-1].Report();
                break;
            }
            else
            {
                Console.WriteLine("Incorrect selection. Please try again...");
                Thread.Sleep(1000);
            }
        }

        Console.WriteLine($"Goal recorded successfully! Your score for this goal is now {_goalList[recordChoice-1].GetScore()}");
        Thread.Sleep(1500);
    }
}