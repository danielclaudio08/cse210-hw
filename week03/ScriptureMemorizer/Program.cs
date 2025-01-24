using System;

// The program works with a library of scriptures instead of just one.
// It randomly selects a scripture to present to the user.
// When all the words are hidden, it will automatically present another stored scripture verse
// or the user could simply just type 'next' for the next scripture to display.
class Program
{
    static void Main(string[] args)
    {
        // Create a library of scriptures
        List<Scripture> Library = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16, 17), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            + "\nFor God sent not his Son into the world to condemn the world; but that the world through him might be saved."),
            new Scripture(new Reference("Moses", 1, 39), "For behold, this is my work and my glory to bring to pass the immortality and eternal life of man."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding."
            + "\nIn all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Amos", 3, 7), "Surely the Lord God will do nothing, but he revealeth his secret unto his servants the prophets."),
            new Scripture(new Reference("1 Corinthians", 6, 19, 20), "What? know ye not that your body is the temple of the Holy Ghost which is in you, which ye have of God, and ye are not your own?"
            + "\nFor ye are bought with a price: therefore glorify God in your body, and in your spirit, which are God’s.")
        };

        Random random = new Random(); // Create a random number generator

        while(true)
        {
            // Pick a random scripture from the library
            Scripture pickedScripture = Library[random.Next(Library.Count)];

            while(true)
            {
                Console.Clear(); // Clear the console
                Console.WriteLine(pickedScripture.GetDisplayText()); // Display the scripture
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit, or type 'next' for the next scripture.");

                string input = Console.ReadLine(); // Get user input
                if(input?.ToLower() == "quit") // If user types 'quit', exit the program
                {
                    return;
                }
                else if(input?.ToLower() == "next") // If user types 'next', pick a new scripture
                {
                    break;
                }

                pickedScripture.HideRandomWords(4);
                if(pickedScripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(pickedScripture.GetDisplayText());
                    Console.WriteLine("\nAll words are hidden. Picking a new scripture.");
                    System.Threading.Thread.Sleep(4000); // delay 4 seconds before the next scripture comes in.
                    break;
                }
            }
        }
    }
}