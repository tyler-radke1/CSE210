using System;
using System.Collections.Generic;

class Video
{
    private string _name;
    private string _title;
    private int _length;
    private List<Comment> _comments;

    public Video(string name, string title = "", int length = 0)
    {
        _name = name;
        _title = title;
        _length = length;
        _comments = new List<Comment>();
    }

    public void DisplayVideoInformation()
    {
        Console.WriteLine($"Poster: {_name}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Comments: {_comments.Count}");
        ReadComments();
    }

    public void AddComment(string commentText, string name)
    {
        Comment commentToAdd = new Comment(text: commentText, name: name);
        _comments.Add(commentToAdd);
    }

    public void ReadComments()
    {
        foreach (var comment in _comments)
        {
            comment.ReadComment();
        }
    }
}
