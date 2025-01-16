public class Entry
{
    public string Date { get; set; } // Date of the entry
    public string PromptText { get; set; } // Prompt for the entry
    public string EntryText { get; set; } // Response to the prompt

    public Entry() { } // Default constructor

    public Entry(string date, string promptText, string entryText) // Parameterized constructor
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }

    // Displays the details of the entry
    public void Display()
    {
        Console.WriteLine($"\nDate: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Response: {EntryText}");
    }
}