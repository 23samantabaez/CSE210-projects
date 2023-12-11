using System;
using System.Collections.Generic;

class Comment
{
    public string _userName { get; }
    public string _text { get; }

    public Comment(string userName, string text)
    {
        _userName = userName;
        _text = text;
    }
}

