using System.Collections.Generic;
using System;

class Video
{

    public string Name { get; set; }
    public string Title { get; set; }
    public int Length { get; set; }

    private List<Comment> _comments;

    public Video(string name, string title = "", int length = 0)
    {
        Name = name;
        Title = title;
        Length = length;
        _comments = new List<Comment>();
    }

    public void DisplayVideoInformation()
    {
        Console.WriteLine($"Poster: {Name}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Length: {Length}");
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
