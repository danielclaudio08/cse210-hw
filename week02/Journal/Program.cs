// Main class to run the program
class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal(); // Create a new journal object
        string choice; // Store user menu choice

        do
        {
            // Display the menu options
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            switch (choice) // Process user choice
            {
                case "1":
                    // Create and add a new journal entry
                    myJournal.AddEntry();
                    break;
                case "2":
                    // Display all journal entries
                    myJournal.DisplayAll();
                    break;
                case "3":
                    // Save journal entries to a file
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    break;
                case "4":
                    // Load journal entries from a file
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    break;
                case "5":
                    // Exit the program
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    // Handle invalid menu choices
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        } while (choice != "5");
    }
}
