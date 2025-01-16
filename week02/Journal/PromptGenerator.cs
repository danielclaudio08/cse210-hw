// Generates random prompts for journal entries
public class PromptGenerator
{
  public List<string>_prompts = new List<string>

  { // List of prompts  to choose from for journal entries
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
  };

  public Random _random = new Random(); // Random number generator

  public string GetRandomPrompt()
  // Returns a random prompt from the predefined list of prompts
  {
    int index = _random.Next(_prompts.Count);
    return _prompts[index];
  }
}
