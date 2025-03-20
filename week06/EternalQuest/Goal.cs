using System.IO;
using System.ComponentModel;

public abstract class Goal
{
  // Private fields to store goal details
  private string _shortName;
  private string _description;
  private int _points;

  // Constructor to initialize goal details
  public Goal(string name, string description, int points)
  {
    _shortName = name;
    _description = description;
    _points = points;
  }

  // Getter for the short name of the goal
  public string GetShortName()
  {
    return _shortName;
  }

  // Getter for the description of the goal
  public string GetDescription()
  {
    return _description;
  }

  // Getter for the points associated with the goal
  public int GetPoints()
  {
    return _points;
  }

  // Abstract method to record an event, to be implemented by derived classes
  public abstract void RecordEvent();

  // Abstract method to check if the goal is complete, to be implemented by derived classes
  public abstract bool IsComplete();

  // Virtual method to get a string representation of the goal details
  public virtual string GetDetailsString()
  {
    return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";
  }

  // Abstract method to get a string representation of the goal, to be implemented by derived classes
  public abstract string GetStringRepresentation();
}
