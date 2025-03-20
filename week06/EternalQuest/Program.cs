using System;
using System.IO;
// This code demonstrates the use of a GoalManager class to manage goals.
// The GoalManager class is responsible for starting the goal management process.
// This implementation exceeds core requirements by adding a deadline feature for each goal,
// enabling users to set and monitor deadlines for their goals, except for EternalGoals, improving the goal management process.
class Program
{
  static void Main(string[] args)
  {
    GoalManager goalManager = new GoalManager();
    goalManager.Start();
  }
}