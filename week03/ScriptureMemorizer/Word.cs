public class Word
{
  private string _text; // Stores the text of the word
  private bool _isHidden; // Indicates if the word is hidden

  // Constructor to initialize the word with text
  public Word(string text)
  {
    _text = text; // Set the text of the word
    _isHidden = false; // Initially, the word is not hidden
  }

  // Method to hide the word
  public void Hide()
  {
    _isHidden = true; // Mark the word as hidden
  }

  // Method to show the word
  public void Show()
  {
    _isHidden = false; // Mark the word as visible
  }

  // Method to check if the word is hidden
  public bool IsHidden()
  {
    return _isHidden;
  }

  // Method to get the display text of the word
  public string GetDisplayText()
  {
    return _isHidden ? new string('_', _text.Length) : _text; // Return underscores if hidden, otherwise return the text
  }
}