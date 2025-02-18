public class Cycling : Activity
{
  private double _speedInKilometersPerHour;

  public Cycling(DateTime date, int length, double speed) : base(date, length)
  {
    _speedInKilometersPerHour = speed;
  }

  public override double GetSpeed()
  {
    return _speedInKilometersPerHour; // Speed is directly provided from the list
  }

  public override double GetDistance()
  {
    return (_speedInKilometersPerHour * GetLength()) / 60; // Distance (km) = (speed * minutes) / 60
  }

  public override double GetPace()
  {
    return 60 / _speedInKilometersPerHour; // Pace (min per km) = 60 / speed
  }
}