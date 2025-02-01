// The Program class contains the Main method which serves as the entry point for the application.
// It creates a list of YouTube videos, adds comments to each video, and displays the video details.
using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    // Create a list of videos
    List<Video> videos = new List<Video>
    {
      new Video("C# Introduction & How it works", "Carlos Zapute", 700),
      new Video("Principle of Abstraction in C#", "Wayde Clinton", 800),
      new Video("Principle of Encapsulation in C#", "Crystal Maiden", 1100),
      new Video("C# in Real World", "Janice Schmit", 900)
    };

    // Add comments to each video
    var video1 = videos[0];
    video1.AddComment(new Comment("Blake@27", "That’s such a brilliant introduction! Thanks a lot!"));
    video1.AddComment(new Comment("@Steve", "Incredibly helpful—thanks a ton!"));
    video1.AddComment(new Comment("Johnny@Bravo", "I appreciate you making it more relevant to me."));

    var video2 = videos[1];
    video2.AddComment(new Comment("MikeTy", "Very well-done with thorough details!"));
    video2.AddComment(new Comment("JimmyDonaldson", "Highly sophisticated content!"));
    video2.AddComment(new Comment("Kate-Kath", "Clearly articulated."));

    var video3 = videos[2];
    video3.AddComment(new Comment("HoneyCOmbs12", "A well-explained breakdown of the principle and its benefits."));
    video3.AddComment(new Comment("@Bayne-Fit", "Comprehensive!"));
    video3.AddComment(new Comment("JREveryting", "Well done!"));

    var video4 = videos[3];
    video4.AddComment(new Comment("Boolean-Master", "Following standards is crucial."));
    video4.AddComment(new Comment("Hanz24", "Incredibly useful guidance."));
    video4.AddComment(new Comment("CrisTina", "Thanks for the information."));

    // Iterate through the list of videos and display their details
    foreach (var video in videos)
    {
      video.DisplayVideoInfo();
    }
    }
}