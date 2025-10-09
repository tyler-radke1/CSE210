using System;

class Comment
{
    private string _commentText;
    private string _commenterName;

    public string CommentText
    {
        get { return _commentText; }
        set { _commentText = value; }
    }

    public string CommenterName
    {
        get { return _commenterName; }
        set { _commenterName = value; }
    }

    public Comment(string text, string name = "Anonymous Poster")
    {
        _commentText = text;
        _commenterName = name;
    }
    public void ReadComment()
    {
        Console.WriteLine($"{_commenterName} said: {_commentText}");
    }
}
