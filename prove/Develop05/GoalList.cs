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
        
        Console.WriteLine("How many points will this earn from completion?");
        completionPoints = Convert.ToInt32(Console.ReadLine());

        if (typeChoice == "1")
        {
            _goalList.Add(new SimpleGoal("Simple Goal", nameChoice, completionPoints, false));
        }
        else if (typeChoice == "2")
        {
            _goalList.Add(new EternalGoal("Eternal Goal", nameChoice, completionPoints, false));
        }
        else if (typeChoice == "3")
        {
            
        }
        else
        {
        }
    }

    public void GetGoalList()
    {

    }

    public void SaveGoalList()
    {
        
    }

    public void LoadGoalList()
    {
        
    }

    


}