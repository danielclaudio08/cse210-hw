using System.Collections.Concurrent;

public class Reference
{
  private string _book;
  private int _chapter;
  private int _verse;
  private int _endVerse;

  // Constructor for a single verse
  public Reference(string book, int chapter, int verse)
  {
    _book = book;
    _chapter = chapter;
    _verse = verse;
    _endVerse = -1; // Indicates no end verse
  }

  // Constructor for multiple verses
  public Reference(string book, int chapter, int startVerse, int endVErse)
  {
    _book = book;
    _chapter = chapter;
    _verse = startVerse;
    _endVerse = endVErse;
  }

  // Method to get the display text of the reference
  public string GetDisplayText()
  {
    if(_endVerse == -1)
    {
      return $"{_book} {_chapter}:{_verse}"; // Return single verse reference
    }
    else
    {
      return $"{_book} {_chapter}:{_verse}-{_endVerse}"; // Return multiple verses reference
    }
  }
}