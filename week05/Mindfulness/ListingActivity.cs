using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
  // List of prompts for the listing activity
  private List<string> _prompts = new()
  {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
  };

  // Constructor for ListingActivity, initializes the base Activity with a name and description
  public ListingActivity() : base("Listing",
                            "This activity will help you reflect on the good things in your life " +
                            "by having you list as many things as you can in a certain area.")
  {
  }

  // Method to run the listing activity
  public void RunListingActivity()
  {
    DisplayStartingMessage();
    string prompt = GetRandomPrompt(); // Get a random prompt from the list
    Console.WriteLine(prompt);
    ShowCountDown(5);
    List<string> responses = GetListFromUser(); // Get the list of responses from the user
    Console.WriteLine($"\nYou listed {responses.Count} items."); // Display the number of items listed
    DisplayEndingMessage();
  }

  // Method to get a random prompt from the list
  private string GetRandomPrompt()
  {
    Random random = new Random();
    int index = random.Next(_prompts.Count);
    return _prompts[index];
  }

  // Method to get a list of responses from the user
  private List<string> GetListFromUser()
  {
    List<string> responses = new();
    Console.WriteLine("My Lists: ");
    DateTime endTime = DateTime.Now.AddSeconds(_duration); // Set the end time for the activity

    // Loop until the current time is less than the end time
    while (DateTime.Now < endTime)
    {
      string response = Console.ReadLine(); // Read user input
      if (!string.IsNullOrEmpty(response))
      {
        responses.Add(response); // Add the response to the list if it's not empty
      }
    }
    return responses;
  }
}