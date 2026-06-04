

//Video Class
public class Video
{
    //Attrbutes, including the list of comments.
    public string _title;

    public string _author;

    public int _length;
    public List<Comment> _commentList;
    
    
    //Constructor. All information for the video itself is passed in as parameters.
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

        //instantiate the comment list. This will be added to in the main method with the .Add() method.
        _commentList = new List<Comment>();
    }

    //returns the number of comments contained in the comment list.
    public int GetCommentNumber()
    {
        return _commentList.Count();
    }

    //Lists the comments, with their author's name and text. Formatted.
    public void ListComments()
    {
        foreach (var comment in _commentList)
        {
            Console.WriteLine($"\nComment by {comment._commentAuthor}: \n'{comment._commentText}'");
        }
    }

    public void ShowVideo()
    {
        //Output information about the video in a formatted way.
        Console.WriteLine("\n-------------------------------------");
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length (Seconds): {_length}");
        Console.WriteLine($"Number of Comments: {GetCommentNumber()}");
        
        //List the comments under each video
        ListComments();
    }
}