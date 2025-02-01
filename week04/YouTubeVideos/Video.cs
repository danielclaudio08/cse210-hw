using System;
using System.Collections.Generic;

public class Video
{
  private string _title; // Stores the title of the video
  private string _author; // Stores the author of the video
  private int _length; // Stores the length of the video in seconds
	private List<Comment> _comments; // Stores the list of comments

  // Constructor to initialize the video with title, author, and length
  public Video(string title, string author, int length)
  {
    _title = title;
    _author = author;
    _length = length;
    _comments = new List<Comment>();
  }

  // Method to add a comment to the video
  public void AddComment(Comment comment)
  {
    _comments.Add(comment);
  }

  // Method to get the number of comments
  public int GetCommentCount()
  {
    return _comments.Count;
  }

  // Method to display video details along with its comments
  public void DisplayVideoInfo()
  {
    Console.WriteLine($"Title: {_title}");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Length: {_length} seconds");
    Console.WriteLine($"Number of Comments: {GetCommentCount()}");
    Console.WriteLine("Comments:");
		
    foreach (var comment in _comments)
    {
      comment.DisplayComment();
    }
    Console.WriteLine();
  }
}