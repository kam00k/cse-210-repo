//Jack Wilson
//CSE210
//Week 3 Develop Project - Encapsulation

class Word
{
    //This class contains a word it is given through the constructor,
    //and a bool that gets flipped when the word becomes hidden. 
    private string _word;
    private bool _isHidden;

    //Constructor assigns the attributes. 
    //_isHidden is set to false by default.
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    //replaces the letters in _word with an equivalent
    //number of underscores, then flips the isHidden bool to true.
    public void ConvertToUnderscore()
    {
        int wordlength = _word.Length;
        _word = new string('_', wordlength);
        _isHidden = true;
    }

    //Returns the _word string
    public string GetWordString()
    {
        return _word;
    }

    //returns the state of _isHidden.
    public bool isHidden()
    {
        return _isHidden;
    }
}
