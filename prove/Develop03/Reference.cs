class Reference
{

    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string referenceString)
    {
        //split the parameter into strings by space
        string[] referenceSegments = referenceString.Split();
        string chapterVerse = referenceSegments[referenceSegments.GetLength(0)-1];
        Console.WriteLine($"chapter and verse: {chapterVerse}");
    }

    public Reference(string book, int chapter, int verse)
    {
        //The scripture constructor will have done all the work for us in this case.
        //honestly since we're parsing strings, this and the next constructor are kind of redundant.
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
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