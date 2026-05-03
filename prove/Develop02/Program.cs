//Jack Wilson
//CSE210
//Abstraction Prove Assignment

//This program does two things to exceed requirements. 
//First, it asks for a description of the weather for each journal entry.
//Second, it warns the user when loading a file and asks if the user
//wants to write the current journal out to a file before it is overwritten.

using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a journal object
        Journal journal = new Journal();

        //Loop until the user exits the program
        while (true)
        {
            //Prompt the user to pick an option from the menu
            Console.WriteLine("\nPlease select from the following:");
            Console.WriteLine("[1] Display all journal entries");
            Console.WriteLine("[2] Write a new journal entry");
            Console.WriteLine("[3] Save current journal to a file");
            Console.WriteLine("[4] Load a journal from a file");
            Console.WriteLine("[5] Exit program");
            string choice = Console.ReadLine();
            
            //Switch/case statement to call functions depending on
            //the option selected. 
            if (choice == "1")
            {
                //call the Display method of each entry in the journal. 
                foreach(var entry in journal._entries)
                {
                entry.Display();
                }
            }

            else if (choice == "2")
            {
                //get the current date as a string and pass it into a call of
                //the NewEntry method, as well as a generated prompt.
                string currentDate = DateTime.Now.ToShortDateString();
                journal.NewEntry(currentDate, GeneratePrompt());
            }

            else if (choice == "3")
            {
                //prompt the user for where they would like their journal saved.
                Console.WriteLine("\nPlease enter the filename you would like to write to.");
                string saveFileName = Console.ReadLine();
                journal.Save(saveFileName);    
            }    
            
            else if (choice == "4")
            {
                //If the list is not empty,
                //Warn the user that the current journal will be overwritten
                //and ask if the user wants to save the current journal first. 
                if (journal._entries.Any())
                {
                    Console.WriteLine("\nThe current journal will be lost if another is loaded.");
                    Console.WriteLine("Would you like to save it first? Y/N");

                    //if the user says yes, get a filename from the user and 
                    //call the Save method first.
                    if(Console.ReadLine() == "Y")
                    {
                        Console.WriteLine("\nPlease enter the filename you would like to write to.");
                        string writeFileName = Console.ReadLine();
                        journal.Save(writeFileName);
                    }            
                } 
                //prompt the user for where they would like their journal loaded from.    
                Console.WriteLine("\nWhat file would you like to load from? ");
                string loadFileName = Console.ReadLine();
                journal.Load(loadFileName);  
            }    

            else if (choice == "5")
            {
                //Exit if the user picks option 5. 
                System.Environment.Exit(0);
            }       
        }
    }
    static string GeneratePrompt()
    {
        //Create a random number object
        Random rnd = new Random();

        //Create an empty string to store the prompt.
        string prompt = "";

        //generate a number between 1 and 5.
        int randInt = rnd.Next(1,6);

        //Switch/case statement to pick the prompt based on the random number.
        switch(randInt)
        {
            case 1:
                prompt = "What was something good that happened to you today?";
                break;
            case 2:
                prompt = "Why was today an exciting day for you?";
                break;
            case 3:
                prompt = "Where did you go today?";
                break;
            case 4:
                prompt = "What song did you get stuck in your head, and what were you doing when it got there?";
                break;
            case 5:
                prompt = "Who did you meet today, and what were they doing when you saw them?";
                break;
            default:
                break;
        }

        //return the prompt
        return prompt;

    }
    
}