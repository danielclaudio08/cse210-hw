public class Fraction
{
  // Fields to store the numerator (_top) and denominator (_bottom) of the fraction
  private int _top;
  private int _bottom;

  // Constructor that has no parameters that initializes the number to 1/1
  public Fraction()
  {
    _top = 1;
    _bottom = 1;
  }

  // Constructor: Initializes the fraction with a whole number (numerator) and sets the denominator to 1
  public Fraction(int wholeNumber)
  {
    _top = wholeNumber;
    _bottom = 1;
  }

  // Constructor: Initializes the fraction with a specific numerator and denominator
  public Fraction(int top, int bottom)
  {
    _top = top;
    _bottom = bottom;
  }

  // Method: Returns the fraction in string format (e.g., "numerator/denominator")
  public string GetFractionString()
  {
    return $"{_top}/{_bottom}";
  }

  // Method: Calculates and returns the decimal value of the fraction
  public double GetDecimalValue()
  {
    return (double)_top / _bottom;
  }

}
