public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string date, string promptText, string entryText)
    // Initializes an entry with a date, prompt, and text.
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"\nDate: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
    }
}
