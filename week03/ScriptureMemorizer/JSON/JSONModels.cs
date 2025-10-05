public class BibleRoot
{
    public List<BookJson> Books { get; set; }
}

public class BookJson
{
    public string Book { get; set; }
    public List<ChapterJson> Chapters { get; set; }
}

public class ChapterJson
{
    public int Chapter { get; set; }
    public string Reference { get; set; }
    public List<VerseJson> Verses { get; set; }
}

public class VerseJson
{
    public string Reference { get; set; }
    public string Text { get; set; }
    public int Verse { get; set; }
}
