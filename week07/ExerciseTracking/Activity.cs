public abstract class Activity
{
  // Private fields to store the date and length of the activity
  private DateTime _date;
  private int _lengthInMinutes;

  // Constructor to initialize the date and length (in minutes) of the activity
  public Activity(DateTime date, int length)
  {
    _date = date;
    _lengthInMinutes = length;
  }

  // Method to retrieve the date of the activity
  public DateTime GetDate()
  {
    return _date;
  }

  // Method to retrieve the length of the activity in minutes
  public int GetLength()
  {
    return _lengthInMinutes;
  }

  // Abstract method to get the distance of the activity (to be implemented by derived classes)
  public abstract double GetDistance();
  // Abstract method to get the speed of the activity (to be implemented by derived classes)
  public abstract double GetSpeed();
  // Abstract method to get the pace of the activity (to be implemented by derived classes)
  public abstract double GetPace();

  // Virtual method to get a summary of the activity
  public virtual string GetSummary()
  {
    // Return a formatted string with the date, type of activity, length, distance, speed, and pace
    return $"[Date: {_date:dd MMM yyyy} | Type of Activity: {base.GetType().Name} | Time: ({_lengthInMinutes} min)] — Distance: {GetDistance():F1} km, " +
    $"Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
  }
}
