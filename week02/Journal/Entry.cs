// Entry class
public class Entry
{
    public string _prompt { get; private set; }
    public string _response { get; set; }
    public string _date { get; set; }

    public Entry(string prompt)
    {
        _prompt = prompt;
    }

    public Entry EnterResponse()
    {
        Console.WriteLine($"Prompt: {this._prompt}");
        Console.Write("Your response: ");
        _response = Console.ReadLine();
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        return this;
    }

    public void displayEntry()
    {
        Console.WriteLine($"Prompt: {this._prompt}");
    }
}
