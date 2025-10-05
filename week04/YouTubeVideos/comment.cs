class Comment
{
    private string _commentText;
    public string _commenterName;

    public Comment(string text, string name = "Anonymous Poster")
    {
        this._commentText = text;
        this._commenterName = name;
    }

    public void ReadComment()
    {
        Console.WriteLine($"{_commenterName} said {_commentText}");
    }
}