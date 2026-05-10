//Jack Wilson
//CSE210
//Week 3 Develop Project - Encapsulation

class Scripture
{
    //the scripture class contains a list of Word objects and a single Reference object.
    private List<Word> _scriptureWordList = new List<Word>();
    private Reference _scriptureReference;

    //Scripture constructor. Populates its class attributes and provides the information to
    //instantiate all the objects its attributes contain. 
    public Scripture(string scriptureText)
    {
        
        //declare variables to pass to the reference constructor
        string bookTitle = "";
        string chapter;
        string startVerse;
        string endVerse = "";

        //split the string passed into the Scripture constructor into two strings by newline character.
        //The first is the reference, the second is the text body.
        string[] splitScriptureAndReference = scriptureText.Split("\n");
        string refSegment = splitScriptureAndReference[0];
        string textSegment = splitScriptureAndReference[1].Trim();

        //split the scripture reference into a chapter and verse.
        string[] referenceParts = refSegment.Split();
        string chapterVerse = referenceParts[referenceParts.GetLength(0)-1];

        //concatenate the words of the book title into a single string and assign it to bookTitle,
        //i.e. for books with multiple words such as "Words of Mormon" or "1 Kings"
        for (int i = 0; i < referenceParts.GetLength(0)-1; i++){
            bookTitle += referenceParts[i] + " ";
        }

        //trim the book title.
        bookTitle = bookTitle.Trim();

        //split the chapterVerse string up into two strings.
        //the first is the chapter number, the second is the verse
        //number(s)
        string[] splitChapVerse = chapterVerse.Split(":");

        //if the latter half of the chapter-verse pair has a hyphen,
        if (splitChapVerse[1].Contains("-"))
        {
            //split the verse range numbers using the hyphen and 
            //assign them to the start and end verses.
            string[] individualVerses = splitChapVerse[1].Split("-");
            startVerse = individualVerses[0];
            endVerse = individualVerses[individualVerses.GetLength(0)-1].Trim();
        }
        //if there's no hyphen, simply assign the latter half of 
        //the chapter-verse pair to the startVerse variable.
        else
        {   
            startVerse = splitChapVerse[1].Trim();
        }

        //assign the first half of the chapter-verse pair to the 
        //chapter variable.
        chapter = splitChapVerse[0];

        //if there's no end verse, call the Reference constructor
        //that takes only a start verse parameter.
        //if there is an end verse, call the Reference constructor
        //that takes both start and end verse parameters. 
        if (endVerse == "")
        {
            _scriptureReference = new Reference(bookTitle, chapter, startVerse);
        }
        else
        {
            _scriptureReference = new Reference(bookTitle, chapter, startVerse, endVerse);
        }

        //split up the words in the text body into strings
        string[] splitTextToWords = textSegment.Split();

        //put each of these strings into new Word objects
        //in the scriptureWordList. 
        foreach (var word in splitTextToWords)
        {
            Word newWord = new Word(word);
            _scriptureWordList.Add(newWord);
        }
    }

    //build the string to print out in the main gameplay loop.
    public string GetRenderedText()
    {
        //Get the scripture reference string and assign it to a variable, along with a newline character for formatting.
        string renderedText = _scriptureReference.GetReferenceString();
        renderedText += "\n";

        //add the _word string from each Word object in the scriptureWordList to the return string, each with a space.
        foreach (var word in _scriptureWordList)
        {
            renderedText += word.GetWordString() + " ";
        }

        //return the completed string.
        return renderedText;
    }

    //Hides a number of not-yet-hidden words.
    public void HideStep()
    {
        //Create a Random object. 
        //Generate a random number between 1 and 3
        //(the number of words to be removed this turn) 
        //Get the number of Word objects in the scripture word list,
        //and create a counter for how many words have been hidden.
        Random randInt = new Random();
        int randWordRemoveNumber = randInt.Next(1,4);
        int listLength = _scriptureWordList.Count();
        int removalCounter = 0;

        //Loops until as many words as randWordRemoveNumber 
        // indicated have been removed.
        while (removalCounter < randWordRemoveNumber)
        {
            //Generate a number between zero and the number of words
            //in the scripture.
            int randListPlace = randInt.Next(0,listLength);

            //test the list to see if it's all hidden first,
            //or depending on where this method is called,
            //the current while loop may run forever.
            if (IsAllHidden() == true)
            {
                break;
            }
            //skip any words that are already hidden.
            if(_scriptureWordList[randListPlace].isHidden() == true)
            {
                continue;
            }
            else
            {
                //increment the removalCounter only when we hide a word.
                _scriptureWordList[randListPlace].ConvertToUnderscore();    
                removalCounter++;
            }
        }
    }

    //checks if all words are hidden.
    public bool IsAllHidden()
    {
        //return false if any word object in 
        //_scriptureWordList is not hidden.
        foreach(var word in _scriptureWordList)
        {
            if (word.isHidden() == false)
            {
                return false;
            }    
        }

        //return true if the loop detects no unhidden words.
        return true;
    }
}