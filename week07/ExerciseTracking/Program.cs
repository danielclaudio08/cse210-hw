using System;

class Program
{
  static void Main(string[] args)
  {
    // Create a list of activities with different types of exercises
    List<Activity> activities = new List<Activity>
    {
      new Running(new DateTime(2022, 11, 03), 30, 4.8),
      new Cycling(new DateTime(2024, 08, 10), 30, 30.0),
      new Swimming(new DateTime(2025, 02, 24), 30, 40)
    };

    // Clear the console
    Console.Clear();
    Console.WriteLine("Exercise Activities");
    Console.WriteLine();

    // Iterate through each activity and print its summary
    foreach(Activity activity in activities)
    {
      Console.WriteLine(activity.GetSummary());
    }
  }
}