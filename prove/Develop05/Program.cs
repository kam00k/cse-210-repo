//Jack Wilson
//CSE 210
//W05 Develop Project

class Program
{
    static void Main(string[] args)
    {
        //create a goalList object
        GoalList goalList = new GoalList();

        //loop until the user exits
        while (true){

            //Show the main menu
            Console.Clear();
            Console.WriteLine("Welcome to the JDubs Goal Tracker\n\nOptions:");
            Console.WriteLine("\n[1] Create a new goal");
            Console.WriteLine("[2] List Goals");
            Console.WriteLine("[3] Save Goals");
            Console.WriteLine("[4] Load Goals");
            Console.WriteLine("[5] Record an Event");
            Console.WriteLine("[6] Quit");

            //Get the activity choice from the user
            Console.Write("Please select the activity you would like to do: ");
            string choice = Console.ReadLine();
            
            //Call a goalList method depending on the choice made
            if(choice == "1")
            {
                goalList.CreateGoal();
            }
            else if (choice == "2")
            {
                goalList.GetGoalList();
            }
            else if (choice == "3")
            {
                goalList.SaveGoalList();
            }
            else if (choice == "4")
            {
                goalList.LoadGoalList();
            }
            else if (choice == "5")
            {
                goalList.Record();
            }

            //break out of the loop (ending the program) if the user picks option 6
            else if (choice == "6")
            {
                break;
            }

            //Handle incorrect entries with a message
            else
            {
                Console.WriteLine("Incorrect entry. Please try again.");
                Thread.Sleep(1500);
            }
        }
    }
}