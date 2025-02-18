public class Swimming : Activity
{
  private int _laps;

  public Swimming(DateTime date, int length, int laps) : base(date, length)
  {
    _laps = laps;
  }

  public override double GetDistance()
  {
    return (_laps * 50) / 1000.0; // Distance (km) = swimming laps * 50 / 1000
  }

  public override double GetSpeed()
  {
    return (GetDistance() / GetLength()) * 60; // Speed (kph) = (distance / minutes) * 60
  }

  public override double GetPace()
  {
    return GetLength() / GetDistance(); // Pace (min per km) = minutes / distance
  }
}