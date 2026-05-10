//Jack Wilson
//CSE210
//Week 3 Develop Project - Encapsulation

class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    //these two constructors are simply fed what the Scripture constructor parses,
    //the second constructor is called if a range of verses is found.
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

    //Combines all the Reference attributes into a single string
    //according to proper formatting and returns it. 
    //behaves differently depending on if the scripture has a range of verses.
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