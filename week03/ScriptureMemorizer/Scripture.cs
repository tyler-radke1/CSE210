public class Scripture
{
    private readonly Reference _reference;
    private string _text;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
    }

    public string GetFullReference()
    {
        return _reference.GetFullReference();
    }

    public string GetFullText()
    {
        return _text;
    }

    public string Hide(string current)
    {
        var words = current.Split(' ');
        var candidates = words
            .Select((word, index) => new { word, index })
            .Where(x => x.word != "_")
            .ToList();

        if (candidates.Count == 0)
            return current;

        var random = new Random();
        var choice = candidates[random.Next(candidates.Count)];
        words[choice.index] = "_";

        return string.Join(' ', words);
    }
}
