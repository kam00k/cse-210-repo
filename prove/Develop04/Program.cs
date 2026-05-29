using System;

class Program
{
    static void Main(string[] args)
    {
        while (true){
            Console.WriteLine("Welcome to Jack Wilson's Serene Grace Mindfulness Activities!");
            Console.WriteLine("\n[1] Breathing Activity");
            Console.WriteLine("[2] Reflection Activity");
            Console.WriteLine("[3] Listing Activity");
            Console.WriteLine("[4] Quit");
            Console.Write("Please select the activity you would like to do: ");

            string choice = Console.ReadLine();
            int duration;
            if (choice == "4")
            {
                Console.WriteLine("Thank you for being mindful with us today.");
                System.Environment.Exit(0);    
            }
            
            Console.WriteLine("Please enter how long you would like to do this activity for (In seconds): ");
            duration = Convert.ToInt32(Console.ReadLine());
            
            if(choice == "1")
            {
                BreathingActivity breathe = new BreathingActivity(duration);
            }
            else if (choice == "2")
            {
                ReflectionActivity reflect = new ReflectionActivity(duration);
            }
            else if (choice == "3")
            {
                ListingActivity list = new ListingActivity(duration);
                list.ListingLoop();
            }
            else
            {
                Console.WriteLine("Incorrect entry. Please try again.");
                Console.Clear();
            }
            
        }
    }
}