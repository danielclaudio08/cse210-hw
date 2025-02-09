using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
  // List of prompts for the reflecting activity
  private List<string> _prompts = new()
  {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
  };

  // List of questions to reflect on the chosen prompt
  private List<string> _questions = new()
  {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
  };

  // Constructor for ReflectingActivity, initializing with a name and description
  public ReflectingActivity() : base("Reflecting",
                                "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
                                "This will help you recognize the power you have and how you can use it in other aspects of your life.")
  {
  }

  // Method to run the reflecting activity
  public void RunReflectingActivity()
  {
    DisplayStartingMessage();
    string prompt = GetRandomPrompt();
    Console.WriteLine(prompt);
    DateTime endTime = DateTime.Now.AddSeconds(_duration);

    // Loop to display random questions until the duration ends
    while (DateTime.Now < endTime)
    {
      string question = GetRandomQuestion();
      Console.WriteLine(question);
      ShowSpinner(3);
    }
    DisplayEndingMessage();
  }

  // Method to get a random prompt from the list
  private string GetRandomPrompt()
  {
    Random random = new Random();
    int index = random.Next(_prompts.Count);
    return _prompts[index];
  }

  // Method to get a random question from the list
  private string GetRandomQuestion()
  {
    Random random = new Random();
    int index = random.Next(_questions.Count);
    return _questions[index];
  }
}