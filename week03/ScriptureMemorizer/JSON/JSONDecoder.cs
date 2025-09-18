using System.Text.Json;

public static class ScripturePicker
{
    public static Scripture GetRandomScripture(ScriptureBook selectedBook)
    {
        var jsonFilePath = selectedBook.GetFileName();

        string json = File.ReadAllText(jsonFilePath);

        // Deserialize
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var bible = JsonSerializer.Deserialize<BibleRoot>(json, options);

        var random = new Random();

        // Pick random book
        var book = bible.Books[random.Next(bible.Books.Count)];

        // Pick random chapter
        var chapter = book.Chapters[random.Next(book.Chapters.Count)];

        // Pick random verse
        var verse = chapter.Verses[random.Next(chapter.Verses.Count)];

        // Build your Reference + Scripture
        var reference = new Reference(book.Book, chapter.Chapter.ToString(), verse.Verse.ToString());
        return new Scripture(reference, verse.Text);
    }
}

public enum ScriptureBook
{
    OldTestament,
    NewTestament,
    BookOfMormon,
    Doctrine
}

public static class ScriptureBookExtensions
{
    private static readonly Dictionary<ScriptureBook, string> FileNames = new()
    {
        { ScriptureBook.OldTestament, "JSON/old-testament.json" },
        { ScriptureBook.NewTestament, "JSON/new-testament.json" },
        { ScriptureBook.BookOfMormon, "JSON/book-of-mormon.json" },
        { ScriptureBook.Doctrine, "JSON/doctrine-and-covenants.json" }
    };

    public static string GetFileName(this ScriptureBook book)
    {
        return FileNames[book];
    }
}
