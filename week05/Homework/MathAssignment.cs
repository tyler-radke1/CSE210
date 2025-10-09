public class MathAssignment: Assignment 
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string textbook, string problems) : base(name, topic)
    {
        this._textbookSection = textbook;
        this._problems = problems;
    }
    public string HomeworkList()
    {
        return $"{_textbookSection} - {_problems}";
    }
}