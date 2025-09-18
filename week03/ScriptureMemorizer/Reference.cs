public class Reference
{
    public string _book { get; }
    public string _chapter { get; }
    public string _verse { get; }

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string GetFullReference()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}