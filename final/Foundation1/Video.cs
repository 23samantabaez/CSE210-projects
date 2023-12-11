using System;
using System.Collections.Generic;

class Video
{
    public string _title { get; }
    public string _author { get; }
    public int _length { get; }
    public List<Comment> Comments { get; }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string userName, string text)
    {
        Comments.Add(new Comment(userName, text));
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

