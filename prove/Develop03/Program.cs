//Jack Wilson
//CSE210
//Week 3 Develop Project - Encapsulation

using System;

class Program
{
    static void Main(string[] args)
    {
        //Instantiate the library of scriptures.
        Library scriptureLibrary = new Library();

        //Instantiate a new Scripture object with a scripture string from the library.
        Scripture gameScripture = new Scripture(scriptureLibrary.GetRandomScripture());
        
        //Display the initial screen
        Console.Clear();
        Console.WriteLine(gameScripture.GetRenderedText());
        Console.WriteLine("\nPlease press 'enter' to incrementally remove words, or type 'quit' at any step to exit.");
        
        //Read an input from the user. If it is quit, end the program.
        string response = Console.ReadLine();
        if (response == "quit")
        {
            System.Environment.Exit(0);
        }

        //loop until all words in the scripture are hidden.
        while (gameScripture.IsAllHidden() == false)
        {         
            //clear the console, hide words and display the current
            //version of the text. 
            Console.Clear();
            gameScripture.HideStep();
            Console.WriteLine(gameScripture.GetRenderedText());
            
            //this check makes the game end as soon as the step to clear the last
            //words is complete, without having the user press "enter" again. 
            if (gameScripture.IsAllHidden() == true)
            {
                break;
            }
            
            //prompt the user for the next step, and exit the program if 'quit' is entered.
            Console.WriteLine("\nPlease press 'enter' to incrementally remove words, or type 'quit' at any step to exit.");
            response = Console.ReadLine();
            if (response == "quit")
            {
                System.Environment.Exit(0);
            }
        }
        //ending message.
        Console.WriteLine("\nScripture is now fully hidden. Well done!");
    }
}