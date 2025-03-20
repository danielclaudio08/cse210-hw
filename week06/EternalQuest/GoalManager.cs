using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

public class GoalManager
{
  private List<Goal> _goals; // List to store goals
  private int _score; // Variable to store the player's score

  public GoalManager()
  {
    _goals = new List<Goal>(); // Initialize the goals list
    _score = 0; // Initialize the score to 0
  }

  public void Start()
  {
    while(true)
    {
      Console.Clear();
      DisplayReminders(); // Display upcoming deadlines
      Console.WriteLine();
      DisplayPlayerInfo(); // Display current score
      Console.WriteLine();
      Console.WriteLine("Menu Options:");
      Console.WriteLine("1. Create New Goal");
      Console.WriteLine("2. List Goals");
      Console.WriteLine("3. Save Goals");
      Console.WriteLine("4. Load Goals");
      Console.WriteLine("5. Record Event");
      Console.WriteLine("6. Exit");
      Console.Write("Select a choice from the menu: ");
      string choice = Console.ReadLine();

      switch(choice)
      {
        case "1":
          CreateGoal(); // Create a new goal
          break;
        case "2":
          ListGoalDetails(); // List all goals
          break;
        case "3":
          SaveGoals(); // Save goals to a file
          break;
        case "4":
          LoadGoals(); // Load goals from a file
          break;
        case "5":
          RecordEvent(); // Record an event for a goal
          break;
        case "6":
          return; // Exit the program
        default:
          Console.WriteLine("Invalid choice. Please try again.");
          Console.ReadKey();
          break;
      }
    }
  }

  private void CreateGoal()
  {
    Console.WriteLine("\nThe Types of Goals are:");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");
    Console.Write("Which type of goal would you like to create? ");
    string choice = Console.ReadLine();

    Console.Write("\nWhat is the name of your goal? ");
    string name = Console.ReadLine();
    Console.Write("What is the description of your goal? ");
    string description = Console.ReadLine();
    Console.Write("What is the amount of points with this goal? ");
    int points = int.Parse(Console.ReadLine());

    switch(choice)
    {
      case "1":
        Console.Write("When is the deadline for this goal (yyyy-mm-dd)? ");
        DateTime simpleGoalDeadline = DateTime.Parse(Console.ReadLine());
        _goals.Add(new SimpleGoal(name, description, points, simpleGoalDeadline)); // Add SimpleGoal
        break;
      case "2":
        _goals.Add(new EternalGoal(name, description, points)); // Add EternalGoal
        break;
      case "3":
        Console.Write("When is the deadline for this goal (yyyy-mm-dd)? ");
        DateTime checklistGoalDeadline = DateTime.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing the target goal? ");
        int bonus = int.Parse(Console.ReadLine());
        _goals.Add(new ChecklistGoal(name, description, points, target, bonus, checklistGoalDeadline)); // Add ChecklistGoal
        break;
      default:
        Console.WriteLine("Invalid choice. Goal not created.");
        break;
    }
    Console.WriteLine("Your new goal is created in the List Goals.");
    Console.ReadKey();
  }

  private void ListGoalDetails()
  {
    Console.WriteLine("\nThe Goals are:");
    foreach(Goal g in _goals)
    {
      Console.WriteLine(g.GetDetailsString()); // Display goal details
    }
    Console.ReadKey();
  }

  private void RecordEvent()
  {
    Console.WriteLine("\nChoose a goal to record:");

    for(int a = 0; a < _goals.Count; a++)
    {
      Console.WriteLine($"{a + 1}. {_goals[a].GetShortName()}"); // List goals
    }
    Console.Write("Enter your choice: ");
    int choice = int.Parse(Console.ReadLine()) - 1;

    if(choice >= 0 && choice < _goals.Count)
    {
      int pointsEarned = _goals[choice].GetPoints();
      _score += pointsEarned; // Update score
      _goals[choice].RecordEvent(); // Record event for the selected goal

      if(_goals[choice] is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
      {
        _score += checklistGoal.GetBonus(); // Add bonus points if checklist goal is complete
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points and a bonus of {checklistGoal.GetBonus()} points.");
      }
      else
      {
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points.");
      }
    }
    else
    {
      Console.WriteLine("Invalid choice. Event not recorded.");
    }
    Console.ReadKey();
  }

  private void DisplayPlayerInfo()
  {
    Console.WriteLine($"You have {_score} points"); // Display current score
  }

  private void DisplayReminders()
  {
    Console.WriteLine("Upcoming Deadlines:");
    List<Goal> goalsToRemove = new List<Goal>();

    foreach(Goal g in _goals)
    {
      if(g is SimpleGoal simpleGoal)
      {
        if(!simpleGoal.IsComplete() && simpleGoal.GetDeadline() <= DateTime.Now.AddDays(7))
        {
          Console.WriteLine($"{simpleGoal.GetShortName()} - Deadline: {simpleGoal.GetDeadline().ToShortDateString()}"); // Display upcoming deadlines for simple goals
        }
        else if(simpleGoal.IsComplete())
        {
          simpleGoal.RemoveDeadline(); // Remove deadline if goal is complete
        }
        else if(simpleGoal.GetDeadline() < DateTime.Now)
        {
          goalsToRemove.Add(simpleGoal); // Mark goal for removal if deadline has passed
        }
      }
      else if(g is ChecklistGoal checklistGoal)
      {
        if(!checklistGoal.IsComplete() && checklistGoal.GetDeadline() <= DateTime.Now.AddDays(7))
        {
          Console.WriteLine($"{checklistGoal.GetShortName()} - Deadline: {checklistGoal.GetDeadline().ToShortDateString()}"); // Display upcoming deadlines for checklist goals
        }
        else if(checklistGoal.IsComplete())
        {
          checklistGoal.RemoveDeadline(); // Remove deadline if goal is complete
        }
        else if(checklistGoal.GetDeadline() < DateTime.Now)
        {
          goalsToRemove.Add(checklistGoal); // Mark goal for removal if deadline has passed
        }
      }
    }

    // Remove goals with expired deadlines
    foreach(Goal g in goalsToRemove)
    {
      _goals.Remove(g);
    }
  }

  private void SaveGoals()
  {
    Console.Write("Enter the filename to save goals: ");
    string filename = Console.ReadLine();

    using(StreamWriter outputFile = new StreamWriter(filename))
    {
      outputFile.WriteLine(_score); // Save current score

      foreach(Goal s in _goals)
      {
        string goalString = s.GetStringRepresentation();
        if(!string.IsNullOrEmpty(goalString))
        {
          outputFile.WriteLine(goalString); // Save goal if it is not expired
        }
      }
    }
    Console.WriteLine("Goals saved successfully.");
    Console.ReadKey();
  }

  private void LoadGoals()
  {
    Console.Write("Enter the filename to load goals: ");
    string filename = Console.ReadLine();

    if(!File.Exists(filename))
    {
      Console.WriteLine("File not found. Please ensure the file exists and try again.");
      Console.ReadKey();
      return;
    }
    _goals.Clear();
    string[] lines = File.ReadAllLines(filename);
    _score = int.Parse(lines[0]); // Load score

    for(int i = 1; i < lines.Length; i++)
    {
      string[] parts = lines[i].Split(':');
      string type = parts[0];
      string[] details = parts[1].Split(',');

      string name = details[0];
      string description = details[1];
      int points = int.Parse(details[2]);

      switch(type)
      {
        case "SimpleGoal":
          DateTime simpleGoalDeadline = DateTime.ParseExact(details[3], "yyyy-MM-dd", null);
          bool isComplete = bool.Parse(details[4]);
          SimpleGoal simpleGoal = new SimpleGoal(name, description, points, simpleGoalDeadline);

          if(isComplete)
          {
            simpleGoal.RecordEvent(); // Mark as complete if loaded goal is complete
          }
          if(simpleGoal.GetDeadline() >= DateTime.Now)
          {
            _goals.Add(simpleGoal); // Add goal if deadline has not passed
          }
          break;
        case "EternalGoal":
          _goals.Add(new EternalGoal(name, description, points)); // Add EternalGoal
          break;
        case "ChecklistGoal":
          DateTime checklistGoalDeadline = DateTime.ParseExact(details[3], "yyyy-MM-dd", null);
          int amountCompleted = int.Parse(details[4]);
          int target = int.Parse(details[5]);
          int bonus = int.Parse(details[6]);
          ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus, checklistGoalDeadline);

          for(int c = 0; c < amountCompleted; c++)
          {
            checklistGoal.RecordEvent(); // Record events for loaded checklist goal
          }
          if(checklistGoal.GetDeadline() >= DateTime.Now)
          {
            _goals.Add(checklistGoal); // Add goal if deadline has not passed
          }
          break;
      }
    }
    Console.WriteLine("Goals loaded successfully.");
    Console.ReadKey();
  }
}