using System;
using System.Threading;

class Program
{
  static void Main(string[] args)
  {
    while (true)
    {
      Console.Clear();
      Console.WriteLine("Welcome to Mindfulness Program!\n");
      Console.WriteLine("Please choose an activity to begin.");
      Console.WriteLine("1. Breathing Activity");
      Console.WriteLine("2. Reflecting Activity");
      Console.WriteLine("3. Listing Activity");
      Console.WriteLine("4. Quit");
      Console.Write("Please enter a number: ");
      string choice = Console.ReadLine();

      // Handle user choice
      switch (choice)
      {
        case "1":
          // Run Breathing Activity with animation effect (see BreathingActivity.cs file)
          new BreathingActivity().RunBreathingActivity();
          Thread.Sleep(5000);
          break;
        case "2":
          // Run Reflecting Activity
          new ReflectingActivity().RunReflectingActivity();
          Thread.Sleep(5000);
          break;
        case "3":
          // Run Listing Activity
          new ListingActivity().RunListingActivity();
          Thread.Sleep(5000);
          break;
        case "4":
          // Exit the program
          return;
        default:
          // Handle invalid choice
          Console.WriteLine("Invalid choice. Please pick a number from 1 to 3 or 4 to exit.");
          Thread.Sleep(3000);
          continue;
      }
    }
  }
}