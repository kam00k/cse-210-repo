class Reference
{

    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string referenceString)
    {
        
    }

    public Reference(string book, int chapter, int verse)
    {
        
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        
    }

    public string GetReferenceString()
    {
        string gottenString;
        if (_endVerse == _startVerse)
        {
            gottenString = $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            gottenString = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        return gottenString;
    }   
}