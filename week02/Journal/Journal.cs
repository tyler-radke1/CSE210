public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void WriteNewEntry(List<string> prompts)
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        Entry newEntry = new Entry(prompts[index]).EnterResponse();
        _entries.Add(newEntry);
        Console.WriteLine("Entry saved!");
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            return;
        }

        Console.WriteLine("\n--- Journal Entries ---");
        foreach (var entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Response: {entry._response}");
            Console.WriteLine("-------------------------");
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }

        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[1])
                {
                    _date = parts[0],
                    _response = parts[2]
                };
                _entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded successfully.");
    }
}