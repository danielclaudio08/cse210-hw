using System.IO;

// Class representing a simple goal, inheriting from the Goal base class.
public class SimpleGoal : Goal
{
  private bool _isComplete; // Indicates if the goal is complete
  private DateTime _deadline; // Stores the deadline for the goal

  // Constructor to initialize the SimpleGoal with name, description, points, and deadline
  public SimpleGoal(string name, string description, int points, DateTime deadline) : base(name, description, points)
  {
    _isComplete = false;
    _deadline = deadline;
  }

  // Getter for the deadline
  public DateTime GetDeadline()
  {
    return _deadline;
  }

  // Marks the goal as complete
  public override void RecordEvent()
  {
    _isComplete = true;
  }

  // Checks if the goal is complete
  public override bool IsComplete()
  {
    return _isComplete;
  }

  // Removes the deadline by setting it to DateTime.MinValue
  public void RemoveDeadline()
  {
    _deadline = DateTime.MinValue;
  }

  // Returns a string representation of the SimpleGoal
  public override string GetStringRepresentation()
  {
    if (_deadline < DateTime.Now)
    {
      return string.Empty; // Return an empty string if the deadline has passed
    }
    return $"SimpleGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_deadline:yyyy-MM-dd},{_isComplete}";
  }

  // Returns a detailed string representation of the SimpleGoal
  public override string GetDetailsString()
  {
    return $"Simple Goal: {base.GetDetailsString()} ({GetPoints()} points)";
  }
}