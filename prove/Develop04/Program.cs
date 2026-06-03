//Jack Wilson
//CSE 210
//W04 Develop Project

class Program
{
    static void Main(string[] args)
    {
        
        ActivityHistory history = new ActivityHistory();

        while (true){
            Console.Clear();
            Console.WriteLine("Welcome to Jack Wilson's Serene Grace Mindfulness Activities!");
            Console.WriteLine("\n[1] Breathing Activity");
            Console.WriteLine("[2] Reflection Activity");
            Console.WriteLine("[3] Listing Activity");
            Console.WriteLine("[4] See Activity History");
            Console.WriteLine("[5] Quit");
            Console.Write("Please select the activity you would like to do: ");

            string choice = Console.ReadLine();
            
            if(choice == "1")
            {
                BreathingActivity breathe = new BreathingActivity();
                breathe.BreathingLoop();
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
                history.GetHistory();
            }
            else if (choice == "5")
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
        Console.WriteLine("Thank you for being mindful with us today.");
    }
}