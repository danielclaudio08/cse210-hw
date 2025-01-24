public class Scripture
{
  // Stores the reference and words of the scripture
  private Reference _reference;
  private List<Word> _words;

  // Constructor to initialize the scripture with a reference and text
  public Scripture(Reference reference, string text)
  {
    _reference = reference;
    _words = new List<Word>();
    foreach(string word in text.Split(' ')) // Split the text into words
    {
      _words.Add(new Word(word)); // Add each word to the list
    }
  }

  // Method to hide a specified number of random words
  public void HideRandomWords(int count)
  {
    Random random = new Random();
    for(int i = 0; i < count; i++) // Loop to hide the specified number of words
    {
      int index = random.Next(_words.Count); // Get a random index
      _words[index].Hide(); // Hide the word at the random index
    }
  }

  // Method to get the display text of the scripture
  public string GetDisplayText()
  {
    string displayText = _reference.GetDisplayText() + "\n"; // Get the reference display text
    foreach(Word word in _words) // Loop through each word
    {
      displayText += word.GetDisplayText() + " "; // Add the word's display text
    }
    return displayText.Trim();
  }

  // Method to check if all words are hidden
  public bool IsCompletelyHidden()
  {
    foreach(Word word in _words)
    {
      if(!word.IsHidden()) // If any word is not hidden
      {
        return false;
      }
    }
    return true; // Return true if all words are hidden
  }
}

