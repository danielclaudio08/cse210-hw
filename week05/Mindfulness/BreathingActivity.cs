// Stretch Activity: Breathing Animation Effect '*'
public class BreathingActivity : Activity
{
  // Constructor for the BreathingActivity class, initializing with a name and description
  public BreathingActivity() : base("Breathing",
                              "This activity will help you relax by walking you through breathing in and out slowly. " +
                              "Clear your mind and focus on your breathing.")
  {
  }

  // Method to run the breathing activity
  public void RunBreathingActivity()
  {
    DisplayStartingMessage();

    // Loop for the duration of the activity, incrementing by 5 seconds each iteration
    for (int i = 0; i < _duration; i += 5)
    {
      ShowBreathingAnimation("Breathe in...", 3, true);
      ShowBreathingAnimation("Breathe out...", 3, false);
    }
    DisplayEndingMessage();
  }

  // Method to show the breathing animation (Stretch: Animation Effect)
  private void ShowBreathingAnimation(string action, int duration, bool isInhaling)
  {
    // Loop to create the animation effect
    for (int a = 0; a <= duration * 6; a++)
    {
      Console.Clear();
      // Display the action (either "Breathe in..." or "Breathe out...")
      Console.WriteLine(action);
      // If isInhaling is true, the length of the animation increases with each iteration (a). If isInhaling is false, the length of the animation decreases with each iteration (duration * 6 - a).
      int length = isInhaling ? a : duration * 6 - a;
      // Display the animation using asterisks
      Console.WriteLine(new string('*', length));
      // Calculates a delay based on the logarithm of the current iteration (a). This creates a non-linear delay, making the animation appear smoother.
      int delay = (int)(125 * (1 + Math.Log(a + 1)));
      // Pauses the execution of the thread for the calculated delay, creating the animation effect.
      Thread.Sleep(delay);
    }
  }
}