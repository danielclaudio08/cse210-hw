using System;
using System.Collections.Generic;
using System.Threading;

// Fields to store the name, description, and duration of the activity.
public class Activity
{
  protected string _name;
  protected string _description;
  protected int _duration;

  // Constructor to initialize the activity with a name and description.
  public Activity(string name, string description)
  {
    _name = name;
    _description = description;
  }

  // Displays the starting message for the activity, including the activity name and description.
  // Prompts the user to input the duration for the activity in seconds and shows a preparation message.
  public void DisplayStartingMessage()
  {
    Console.WriteLine($"\n{_name} Activity\n");
    Console.WriteLine(_description);
    Console.Write("How many seconds would you like to set for this activity? ");
    _duration = int.Parse(Console.ReadLine());
    Console.WriteLine("\nPrepare to begin...\n");
    ShowSpinner(2);
  }

  // Displays the ending message.
  public void DisplayEndingMessage()
  {
    Console.WriteLine("\nWell done!");
    Console.WriteLine($"You have completed {_name} Activity for {_duration} seconds!");
  }

  // Displays a spinner animation in the console for a specified number of seconds.
  public void ShowSpinner(int seconds)
  {
    // Array to store the characters for the spinner animation.
    char[] spinnerAnnimation = { '/', '-', '\\', '|' };

    // Loop through the specified number of seconds.
    for (int s = 0; s < seconds; s++)
    {
      foreach (char c in spinnerAnnimation)
      {
      Console.Write(c);
      Thread.Sleep(1000);
      // Erase the previous character to create the spinner animation effect.
      Console.Write("\b");
      }
    }
  }

  // Displays a countdown timer on the console.
  public void ShowCountDown(int seconds)
  {
    // Loop through the specified number of seconds in reverse order to display the countdown.
    for (int n = seconds; n > 0; n--)
    {
      Console.Write(n);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
  }
}