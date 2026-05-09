class Scripture
{
    //private string _scriptureText;
    private List<Word> _scriptureWordList = new List<Word>();
    private Reference _scriptureReference;

    public Scripture(string scriptureText)
    {
        
        //declare variables for calling the reference
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

        //if the latter half of the chapter-verse pair has a "-",
        if (splitChapVerse[1].Contains("-"))
        {
            //split the verse range numbers using the hyphen and 
            //assign them to the start and end verses.
            string[] individualVerses = splitChapVerse[1].Split("-");
            startVerse = individualVerses[0];
            endVerse = individualVerses[individualVerses.GetLength(0)-1].Trim();
        }
        //if there's no hyphen,
        else
        {   
            //just assign the latter half of the chapter-verse pair
            //to the startVerse variable.
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

        string[] splitTextToWords = textSegment.Split();
        foreach (var word in splitTextToWords)
        {
            Word newWord = new Word(word);
            _scriptureWordList.Add(newWord);
        }
    }

    public string GetRenderedText()
    {
        string renderedText = _scriptureReference.GetReferenceString();
        renderedText += "\n";
        foreach (var word in _scriptureWordList)
        {
            renderedText += word.GetWordString() + " ";
        }
        return renderedText;
    }

    public void HideStep()
    {
        Random randInt = new Random();
        int randWordRemoveNumber = randInt.Next(1,4);
        int listLength = _scriptureWordList.Count();
        int removalCounter = 0;
        while (removalCounter < randWordRemoveNumber)
        {
            int randListPlace = randInt.Next(0,listLength);
            if(_scriptureWordList[randListPlace].isHidden() == true)
            {
                continue;
            }
            else
            {
                _scriptureWordList[randListPlace].ConvertToUnderscore();    
                removalCounter++;
            }
        }
    }

    public bool IsAllHidden()
    {
        foreach(var word in _scriptureWordList)
        {
            if (word.isHidden() == false)
            {
                return false;
            }    
        }
        return true;
    }
}