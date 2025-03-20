using System.Security.Principal;
using System.IO;

// Class representing a checklist goal, inheriting from the Goal base class
public class ChecklistGoal : Goal
{
  // Private fields
  private int _amountCompleted; // Tracks the number of times the goal has been completed
  private int _target; // The target number of completions required to achieve the goal
  private int _bonus; // Bonus points awarded upon reaching the target
  private DateTime _deadline; // Deadline for completing the goal

  // Constructor to initialize the ChecklistGoal
  public ChecklistGoal(string name, string description, int points, int target, int bonus, DateTime deadline) : base(name, description, points)
  {
    _amountCompleted = 0;
    _target = target;
    _bonus = bonus;
    _deadline = deadline;
  }

  // Method to get the bonus points
  public int GetBonus()
  {
    return _bonus;
  }

  // Method to get the deadline
  public DateTime GetDeadline()
  {
    return _deadline;
  }

  // Method to remove the deadline
  public void RemoveDeadline()
  {
    _deadline = DateTime.MinValue;
  }

  // Method to record an event (increment the amount completed)
  public override void RecordEvent()
  {
    _amountCompleted++;
  }

  // Method to check if the goal is complete
  public override bool IsComplete()
  {
    return _amountCompleted >= _target;
  }

  // Method to get the details of the goal as a string
  public override string GetDetailsString()
  {
    return $"Checklist Goal: {base.GetDetailsString()} --> Currently Completed: {_amountCompleted}/{_target} ({GetPoints()} points) + when target is reached, {_bonus} bonus points";
  }

  // Method to get a string representation of the goal
  public override string GetStringRepresentation()
  {
    if (_deadline < DateTime.Now)
    {
      return string.Empty; // Return an empty string if the deadline has passed
    }
    return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_deadline:yyyy-MM-dd},{_amountCompleted},{_target},{_bonus}";
  }
}