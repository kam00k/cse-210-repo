//Jack Wilson
//CSE 210
//W04 Develop Project

//This program exceeds requirements by implementing an Activity History,
//Which displays how many times the user has performed an activity in
//the current session.
class Program
{
    static void Main(string[] args)
    {
        //Create an activity history list
        ActivityHistory history = new ActivityHistory();

        //loop until the user exits the program
        while (true){

            //Clear the terminal and display the options
            Console.Clear();
            Console.WriteLine("Welcome to Jack Wilson's Serene Grace Mindfulness Activities!");
            Console.WriteLine("\n[1] Breathing Activity");
            Console.WriteLine("[2] Reflection Activity");
            Console.WriteLine("[3] Listing Activity");
            Console.WriteLine("[4] See Activity History");
            Console.WriteLine("[5] Quit");
            Console.Write("Please select the activity you would like to do: ");

            //read in the user's choice
            string choice = Console.ReadLine();
            
            //Run different activities depending on the user's choice.
            if(choice == "1")
            {
                BreathingActivity breathe = new BreathingActivity();
                breathe.BreathingLoop();

                //Increment the history counter for this activity.
                history.SetHistory(0);
            }
            else if (choice == "2")
            {
                ReflectionActivity reflect = new ReflectionActivity();
                reflect.ReflectionLoop();
                history.SetHistory(1);
            }
            else if (choice == "3")
            {
                ListingActivity list = new ListingActivity();
                list.ListingLoop();
                history.SetHistory(2);
            }
            else if (choice == "4")
            {
                //Displays the Activity history. Does not persist after the program ends.
                history.GetHistory();
            }
            //Exit the program by breaking the main loop if the fifth option is chosen.
            else if (choice == "5")
            {
                break;
            }
            else
            {
                //handle erroneous choices made by displaying a message and returning to the main menu.
                Console.Clear();
                Console.WriteLine("Incorrect entry. Please try again.");
                Thread.Sleep(1500);
                Console.Clear();
            }
        }
        //Display a closing message. 
        Console.WriteLine("Thank you for being mindful with us today.");
    }
}