//Jack Wilson
//CSE210
//Abstraction Prove Assignment

using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

public class Journal
{
    //Declare and instantiate a public list of Entry objects. 
    public List<Entry> _entries = new List<Entry>();


    //Method for writing a new journal entry.
    public void NewEntry(string date, string prompt)
    {

        //Create a new Entry object that we will populate.
        Entry entry = new Entry();

        //Get a random prompt and store it in the prompt attribute.
        entry._prompt = prompt;

        //Set the entry's prompt
        entry._date = date;

        //Prompt the user for their journal entry and a comment on the weather,
        //and add them to the entry with the date and generated prompt.
        Console.WriteLine("\nType your journal entry below. You may use the prompt below to start you off, if you wish. \nPlease do not press the Enter key until you are finished.");
        Console.WriteLine($"Today's date is: {entry._date}");
        Console.WriteLine("What was the weather like today?");
        entry._weather = Console.ReadLine();
        Console.WriteLine($"{entry._prompt}");
        entry._textBody = Console.ReadLine();

        //add the completed entry object to the journal's list
        _entries.Add(entry);
    }

    //Method for writing the current journal out to a file.
    public void Save(string filename)
    {
        
        //Create an object to write out to a file
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            //Find out how many entries there are in the journal
            int entryCount = _entries.Count();

            //Loop through the journal's entries, EXCEPT for the last one. 
            for (int i = 0; i < entryCount - 1; i++)
            {
                //write the journal entry's details out to the 
                //file, including a unique separator. 
                outputFile.WriteLine(_entries[i]._date);
                outputFile.WriteLine(_entries[i]._weather);
                outputFile.WriteLine(_entries[i]._prompt);
                outputFile.WriteLine(_entries[i]._textBody);
                outputFile.Write("~|~");
            }
                //Now write out the details of the last entry,
                //this time with no separator.
                outputFile.WriteLine(_entries[entryCount-1]._date);
                outputFile.WriteLine(_entries[entryCount-1]._weather);
                outputFile.WriteLine(_entries[entryCount-1]._prompt);
                outputFile.WriteLine(_entries[entryCount-1]._textBody);
        }
        //Tell the user the journal has been successfully written. 
        Console.WriteLine("\nFile successfully written.");
    }

    //method for loading a journal file. Make sure it is formatted correctly.
    //It is probably best to save a journal to a file using this program
    //so you have something that will load correctly. 
    public void Load(string filename)
    {
        

        //Clear the current journal. 
        _entries.Clear();

        //read the text of the file into a single string
        string allJournal = System.IO.File.ReadAllText(filename);

        //split the file into entries based on this funky separator string
        string[] entries = allJournal.Split("~|~");

        //For each entry,
        foreach(string entry in entries)
        {

            //split the entry into sections. As long as the first three are what we need,
            //we don't need to worry about extras. 
            string[] lines = entry.Split("\n");
            
            //Make a new entry object and populate it 
            //with each line pulled from the current 
            //group of lines. Trim the lines while
            //assigning them or writing them to file
            //later will cause consistency problems. 
            Entry loadEntry = new Entry();
            loadEntry._date = lines[0].Trim();
            loadEntry._weather = lines[1].Trim();
            loadEntry._prompt = lines[2].Trim();
            loadEntry._textBody = lines[3].Trim();

            //Add the newly-read entry to the journal's list.
            _entries.Add(loadEntry);
        }

        //Tell the user the journal has been successfully loaded. 
        Console.WriteLine("\nFile successfully loaded.");
    }
}
