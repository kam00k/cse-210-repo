class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void ConvertToUnderscore()
    {
        int wordlength = _word.Length;
        _word = new string('_', wordlength);
        _isHidden = true;
    }

    public string GetWordString()
    {
        string wordString = _word;
        return wordString;
    }

    public bool isHidden()
    {
        return _isHidden;
    }
}
