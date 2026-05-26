class Video
{
    private string _title;
    private string _author;
    private List<Comment> _comments = new List<Comment>();
    private int _lengthInSeconds;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
    }
    public int NumberOfComments()
    {
        int commentAmount = _comments.Count;
        return commentAmount;
    }
    public void AddComment(string author, string commentText)
    {
        Comment comment = new Comment(author, commentText);
        _comments.Add(comment);
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
    public string GetDisplayText()
    {
        return $"Title: {_title} \nAuthor: {_author} \nLength: {_lengthInSeconds} seconds \nNumber of Comments: {NumberOfComments()}";
    }
}