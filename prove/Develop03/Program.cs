using System;

class Program
{
    static void Main(string[] args)
    {

        //load a raw scripture. In this case we're just using a single string. 
        string scripture = ("John 3:16\nFor God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        
        //this version will be used to test using separate strings
        //string scripture = ("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        //string reference = ("John 3:16");

        //instantiate a new Scripture object with the scripture string.
        Scripture gameScripture = new Scripture(scripture);
        
        //Display the initial screen
        Console.Clear();
        Console.WriteLine(gameScripture.GetRenderedText());
        Console.WriteLine("Please press enter to incrementally remove words, or type 'quit' at any step to exit.");
        string response = Console.ReadLine();
        if (response == "quit")
        {
            System.Environment.Exit(0);
        }
        while (gameScripture.IsAllHidden() == false)
        {         
            Console.Clear();
            gameScripture.HideStep();
            Console.WriteLine(gameScripture.GetRenderedText());
            string loopResp = Console.ReadLine();
            if (loopResp == "quit")
            {
                System.Environment.Exit(0);
            }
        }
    }
}