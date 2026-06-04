//Jack Wilson
//CSE 210
//Final Project, Program 1

//Comment class
public class Comment
{
    //Author's name and text attributes
    public string _commentAuthor;
    public string _commentText;

    //Constructor, populates the commentAuthor and text. 
    //No getter methods here since this assignment is just for abstraction
    public Comment(string author, string text)
    {
        _commentAuthor = author;
        _commentText = text;
    }
}