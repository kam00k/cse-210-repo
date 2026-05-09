class Reference
{

    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    public Reference(string referenceString)
    {
        //split the parameter into strings by space
        string[] referenceSegments = referenceString.Split();
        string chapterVerse = referenceSegments[referenceSegments.GetLength(0)-1];
        string bookTitle = "";

        //concatenate the words of the book title into a single string,
        //i.e. for books with multiple words such as "Words of Mormon" or "1 Kings"
        for (int i = 0; i < referenceSegments.GetLength(0)-1; i++){
            bookTitle += referenceSegments[i] + " ";
        }
        
        //split the chapterVerse bit up into numbers
        string[] splitChapVerse = chapterVerse.Split(":");

        //if the latter half of the chapter-verse pair has an "-",
        if (splitChapVerse[1].Contains("-"))
        {
            string[] individualVerses = splitChapVerse[1].Split("-");
            _startVerse = individualVerses[0].Trim();
            _endVerse = individualVerses[individualVerses.GetLength(0)-1].Trim();
        }
        else
        {
            _startVerse = splitChapVerse[1].Trim();
            _endVerse = _startVerse;
        }
    
        _book = bookTitle.Trim();
        _chapter = splitChapVerse[0];

    }

    public Reference(string book, string chapter, string verse)
    {
        //The scripture constructor will have done all the work for us in this case.
        //honestly since we're parsing strings, this and the next constructor are kind of redundant.
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