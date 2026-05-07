class Scripture
{
    //private string _scriptureText;
    //private string _scriptureWordList;
    private Reference _scriptureReference;

    public Scripture(string scriptureText)
    {
        string[] splitScriptureAndReference = scriptureText.Split("\n");
        string refSegment = splitScriptureAndReference[0];
        string textSegment = splitScriptureAndReference[1];
        _scriptureReference = new Reference(refSegment);
    }

    public Scripture(string scriptureText, string reference)
    {
        
    }

    public string GetRenderedText()
    {
        return "renderedText";
    }

    public void HideStep()
    {
        
    }

    public bool IsAllHidden()
    {
        return true;
    }
}