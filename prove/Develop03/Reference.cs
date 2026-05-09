class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    public Reference(string book, string chapter, string startVerse, string endVerse)
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