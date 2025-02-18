public class Running : Activity
{
  private double _distanceInKilometers;

  public Running(DateTime date, int length, double distance) : base(date, length)
  {
    _distanceInKilometers = distance;
  }

  public override double GetDistance()
  {
    return _distanceInKilometers; // Distance is directly provided from the list
  }

  public override double GetSpeed()
  {
    return (_distanceInKilometers / GetLength()) * 60; // Speed (kph) = (distance / minutes) * 60
  }

  public override double GetPace()
  {
    return GetLength() / _distanceInKilometers; // Pace (min per km) = minutes / distance
  }
}