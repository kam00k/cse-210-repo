using System.IO;
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
            Console.WriteLine(goal.GetGoalString());
        }
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
        
    }

    public void Record()
    {
        for (int i = 0; i < _goalList.Count; i++)
        {
            Console.WriteLine($"[{i+1}] []")
        }
    }
    


}