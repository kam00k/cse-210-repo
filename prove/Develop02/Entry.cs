//Jack Wilson
//CSE210
//Abstraction Prove Assignment

using System.Collections;
using System.Diagnostics;

//Entry class
public class Entry
{
    //Make strings for the prompt, the date and the journal entry itself.
    public string _prompt;
    public string _date;
    public string _textBody;

    public string _weather;


    //method to display the contents of the journal entry.
    public void Display()
    {
        Console.WriteLine($"\nDate: {_date}\nWeather: {_weather}\nPrompt: {_prompt}\n{_textBody}\n");
    }

    
}