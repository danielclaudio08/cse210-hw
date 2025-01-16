using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        string choice;

        do
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    myJournal.AddEntry();
                    break;
                case "2":
                    myJournal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter the file name: ");
                    myJournal.SaveToFile(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter the file name: ");
                    myJournal.LoadFromFile(Console.ReadLine());
                    break;
            }
        } while (choice != "5");
    }
}
