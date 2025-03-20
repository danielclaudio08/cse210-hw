using System.IO;

// Class representing an eternal goal, inheriting from the Goal base class
public class EternalGoal : Goal
{
  // Constructor to initialize the eternal goal with name, description, and points
  public EternalGoal(string name, string description, int points) : base(name, description, points)
  {
  }

  // Method to record an event related to the goal (no implementation needed for eternal goals)
  public override void RecordEvent()
  {
  }

  // Method to check if the goal is complete (always returns false for eternal goals)
  public override bool IsComplete()
  {
    return false;
  }

  // Method to get a string representation of the eternal goal
  public override string GetStringRepresentation()
  {
    return $"EternalGoal:{GetShortName()},{GetDescription()},{GetPoints()}";
  }

  // Method to get a detailed string representation of the eternal goal
  public override string GetDetailsString()
  {
    return $"Eternal Goal: [{(IsComplete() ? "X" : " ")}] {GetShortName()} ({GetDescription()}) ({GetPoints()} points)";
  }
}
