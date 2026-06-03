public class GoalList
{
    List<Goal> _goalList;
    int totalScore;

    public GoalList()
    {
        
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
        
        Console.WriteLine("What would you like to name your goal?");
        nameChoice = Console.ReadLine();
        
        Console.WriteLine("How many points will this earn from a single completion?");
        completionPoints = Convert.ToInt32(Console.ReadLine());

        if (typeChoice == "1")
        {
            _goalList.Add(new SimpleGoal("Simple Goal", nameChoice, completionPoints, 0, false));
        }
        else if (typeChoice == "2")
        {
            _goalList.Add(new EternalGoal("Eternal Goal", nameChoice, completionPoints, 0));
        }
        else if (typeChoice == "3")
        {
            Console.WriteLine("How many repeats would you like to require for full completion of this goal?");
            int bonusThreshold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many bonus points would you like for full completion of this goal?");
            int bonusPoints = Convert.ToInt32(Console.ReadLine());

            _goalList.Add(new ChecklistGoal("Checklist Goal", nameChoice, completionPoints, 0, false, 0, bonusThreshold, bonusPoints));
        }
        else
        {
        }
    }

    public void GetGoalList()
    {
        foreach (var goal in _goalList)
        {
            
        }
    }

    public void SaveGoalList()
    {
        
    }

    public void LoadGoalList()
    {
        
    }

    public void Record()
    {
        
    }
    


}