//Jack Wilson
//CSE 210
//W05 Develop Project

using System.Diagnostics.Contracts;
using System.IO;
public class GoalList
{
    //list of Goal objects attributes.
    private List<Goal> _goalList;

    //Constructor. Initializes the _goalList attribute.
    public GoalList()
    {
        _goalList = new List<Goal>();
    }
    
    //Method for creating a goal.
    public void CreateGoal()
    {
        //Variables for storing user choices.
        string typeChoice;
        string nameChoice;
        int completionPoints;

        //Show the menu for creating goals.
        Console.Clear();
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("[1] Simple Goal");
        Console.WriteLine("[2] Eternal Goal");
        Console.WriteLine("[3] Checklist Goal");
        Console.WriteLine("[4] Quit");
        typeChoice = Console.ReadLine();
        
        //Handle quit and erroneous choices first.
        if (typeChoice == "4")
        {
            return;
        }
        else if (typeChoice != "1" && typeChoice != "2" && typeChoice != "3" && typeChoice != "4")
        {
            Console.WriteLine("Incorrect option. Returning to main menu...");
            Thread.Sleep(1500);
        }
        
        //Get the goal name and base score reward from the user (applies to all goal types)
        Console.WriteLine("What would you like to name your goal?");
        nameChoice = Console.ReadLine();
        
        Console.WriteLine("How many points will this earn from a single completion?");
        completionPoints = Convert.ToInt32(Console.ReadLine());

        //Now we handle the choice of goal type
        if (typeChoice == "1")
        {
            _goalList.Add(new SimpleGoal("Simple", nameChoice, completionPoints, 0, false));
        }
        else if (typeChoice == "2")
        {
            _goalList.Add(new EternalGoal("Eternal", nameChoice, completionPoints, 0));
        }

        //Checklist goals require another couple of user inputs and variables for the bonus points.
        else
        {
            Console.WriteLine("How many repeats would you like to require for full completion of this goal?");
            int bonusThreshold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many bonus points would you like for full completion of this goal?");
            int bonusPoints = Convert.ToInt32(Console.ReadLine());

            _goalList.Add(new ChecklistGoal("Checklist", nameChoice, completionPoints, 0, false, 0, bonusThreshold, bonusPoints));
        }
    }

    //Method for displaying the goal list.
    public void GetGoalList()
    {
        //loop through the list of Goal objects.
        for (int i = 0; i < _goalList.Count; i++)
        {
            //This variable exists primarily for legibility of the Console.WriteLine statements.
            Goal tempGoal = _goalList[i];

            //Print to the terminal according to different formats based on the Goal type
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
                Console.WriteLine($"[{tempGoal.IsComplete()}] Checklist: {tempGoal.GetName()} [{tempGoal.GetChecklistProgress()}]  | Score: {tempGoal.GetScore()}");    
            } 
        }
        //Display the total score and wait for user input to return to the main menu.
        Console.WriteLine($"Total Score: {GetTotalScore()}");
        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadLine();
    }


    //Calculates the total score of all goals in the list.
    public int GetTotalScore()
    {
        int grandTotal = 0;
        foreach(var goal in _goalList)
        {
            grandTotal += goal.GetScore();
        }
        return grandTotal;
    }

    //Saves the 
    public void SaveGoalList()
    {
        //Get a filename from the user.
        Console.WriteLine("Enter the filename you would like to save this goal list to:");
        string filename = Console.ReadLine();

        //Write each goal as a separate line to the given file.
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var goal in _goalList)
            {
                outputFile.WriteLine(goal.GetGoalString());       
            }            
        }
        //End with a message to the user before returning to the main menu.
        Console.WriteLine($"\nFile written successfully!");
        Thread.Sleep(1500);
        
    }

    public void LoadGoalList()
    {
        //Clear the goal list, get a filename and create a string array to store all the lines in the file
        _goalList.Clear();
        Console.WriteLine("Enter the filename you would like to load the goal list from:");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        //Iterate through the file lines array.
        foreach (string line in lines)
        {
            //Split each line by comma and trim each resulting string
            string[] strings = line.Split(",");
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i].Trim();
            }

            //Load each goal according to type. This is done based on how many elements the line has.
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
        //End with a message to the user before returning to the main menu.
        Console.WriteLine($"\nFile loaded successfully!");
        Thread.Sleep(1500);
    }

    //Records completion (or progress) in a goal.
    public void Record()
    {
        //variable to store the user's choice of goal to record.
        int recordChoice;

        //Show the list of goals, each with a number beside it.
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
                Console.WriteLine($"[{i+1}] [{tempGoal.IsComplete()}] Checklist: {tempGoal.GetName()} [{tempGoal.GetChecklistProgress()}]  | Score: {tempGoal.GetScore()}");    
            } 
        }

        //Loop until a correct input is received.
        while (true)
        {
            //Get the desired goal to record from the user.
            Console.WriteLine("Please select the activity you would like to record to:");
            recordChoice = Convert.ToInt32(Console.ReadLine());

            //if the choice is within the number of available goals, call the report method of that goal.
            if (recordChoice > 0 && recordChoice < _goalList.Count+1)
            {
                _goalList[recordChoice-1].Report();
                break;
            }

            //Otherwise, ask the user to try again.
            else
            {
                Console.WriteLine("Incorrect selection. Please try again...");
                Thread.Sleep(1000);
            }
        }

        //End with a message to the user, showing the current score for the selected goal after completion.
        Console.WriteLine($"Goal recorded successfully! Your score for this goal is now {_goalList[recordChoice-1].GetScore()}");
        Thread.Sleep(1500);
    }
}