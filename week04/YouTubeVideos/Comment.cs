public class Comment
{
  private string _commenterName; // Stores the name of the person who made the comment
  private string _commentText; // Stores the text of the comment

  // Constructor to initialize the comment with name and text
  public Comment(string commenterName, string commentText)
  {
    _commenterName = commenterName;
    _commentText = commentText;
  }

    // Method to display the commenter's name and text
  public void DisplayComment()
  {
    Console.WriteLine($"[User] {_commenterName}: {_commentText}");
  }
}