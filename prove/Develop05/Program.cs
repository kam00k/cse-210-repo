

class Program
{
    static void Main(string[] args)
    {
        GoalList goalList = new GoalList();

        while (true){
            Console.Clear();
            Console.WriteLine("Welcome to the JDubs Goal Tracker\nOptions:");
            Console.WriteLine("\n[1] Create a new goal");
            Console.WriteLine("[2] List Goals");
            Console.WriteLine("[3] Save Goals");
            Console.WriteLine("[4] Load Goals");
            Console.WriteLine("[5] Record an Event");
            Console.WriteLine("[6] Quit");
            Console.Write("Please select the activity you would like to do: ");

            string choice = Console.ReadLine();
            
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
            else if (choice == "6")
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect entry. Please try again.");
                Thread.Sleep(1500);
                Console.Clear();
            }
        }
    }
}