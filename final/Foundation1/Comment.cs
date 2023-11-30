
class Comment
{
    public string _commenterName { get; }
    public string _commentContent { get; }

    public Comment(string commenterName, string commentContent)
    {
        _commenterName = commenterName;
        _commentContent = commentContent;
    }
}

