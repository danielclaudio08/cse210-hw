// Save or load your document to a database or use a different library or format such as JSON for storage.
using System.Text.Json;
public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private PromptGenerator _promptgenerator = new PromptGenerator(); // Generates prompts

    // Creates and adds a new journal entry
    public void AddEntry()
    {
        string prompt = _promptgenerator.GetRandomPrompt(); // Get a random prompt
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString(); // Use the current date

        Entry newEntry = new Entry(date, prompt, response); // Create the new entry
        _entries.Add(newEntry); // Add the new entry to the list
    }

    // Displays all entries in the journal
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal."); // Show if the journal is empty
            return;
        }

        foreach (var entry in _entries)
        {
            entry.Display(); // Display each entry
        }
    }

    // Saves all entries to a file in JSON format
    public void SaveToFile(string file)
    {
        string json = JsonSerializer.Serialize(_entries);
        File.WriteAllText(file, json);
    }

    // Loads all entries from a file in JSON format
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            string json = File.ReadAllText(file);
            _entries = JsonSerializer.Deserialize<List<Entry>>(json);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}