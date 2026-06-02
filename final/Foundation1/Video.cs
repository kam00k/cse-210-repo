public class Video
{
    public string _title;

    public string _author;

    public int _length;
    public List<Comment> _commentList;
    
    
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _commentList = new List<Comment>();
    }

    public int GetCommentNumber()
    {
        return _commentList.Count();
    }

    public void ListComments()
    {
        foreach (var comment in _commentList)
        {
            Console.WriteLine($"Comment by {comment._commentAuthor}: \n'{comment._commentText}'");
        }
    }
}