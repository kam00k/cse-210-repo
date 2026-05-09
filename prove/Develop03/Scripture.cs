class Scripture
{
    //private string _scriptureText;
    private List<Word> _scriptureWordList = new List<Word>();
    private Reference _scriptureReference;

    public Scripture(string scriptureText)
    {
        string[] splitScriptureAndReference = scriptureText.Split("\n");
        string refSegment = splitScriptureAndReference[0];
        string textSegment = splitScriptureAndReference[1].Trim();
        _scriptureReference = new Reference(refSegment);

        string[] splitTextToWords = textSegment.Split();
        foreach (var word in splitTextToWords)
        {
            Word newWord = new Word(word);
            _scriptureWordList.Add(newWord);
        }
    }

    public Scripture(string scriptureText, string reference)
    {
        
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