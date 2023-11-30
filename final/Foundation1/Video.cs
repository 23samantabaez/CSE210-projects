using System;
using System.Collections.Generic;

class Video()
{
    public string _title {get; }
    public string _author {get; }
    public int _length {get; }
    public List<Comment> commentsList {get; } = new List<Comment>();


    public Video(string title, string author, int length, List<Comment> commentsList) //: this (title, author, length, new List<Comment>())
    {
        string _title = title;
        string _author = author;
        int _length = length; 
        //commentsList = new List<Comment>();
    }

    public void AddComment(string _commenterName, string _commentContent)
    {
        commentsList.Add(new Comment(_commenterName, _commentContent));
    }

    public int NumComments()
    {
        return commentsList.Count;
    }
}

