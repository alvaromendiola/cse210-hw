using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create some videos
        Video video1 = new Video("Moroni Juarez: Heroes We Can Rely On", "Ensign College", 1477);
        Video video2 = new Video("Brian Ashton: Preparing For The Second Coming Of The Lord Jesus Christ", "Ensign College", 1636);
        Video video3 = new Video("3 Truths That Will Transform Your Relationship with God", "Ensign College", 1510);
        
        // Add comments to video1
        video1.AddComment(new Comment("Alpha", "Great talk"));
        video1.AddComment(new Comment("Beta", "Very inspiring"));
        video1.AddComment(new Comment("Gamma", "Thank you for the video"));

        // Add comments to video2
        video2.AddComment(new Comment("Alpha", "Thank you for the video"));
        video2.AddComment(new Comment("Beta", "Great talk"));
        video2.AddComment(new Comment("Gamma", "Very inspiring"));

        // Add comments to video3
        video3.AddComment(new Comment("Alpha", "Very inspiring"));
        video3.AddComment(new Comment("Beta", "Thank you for the video"));
        video3.AddComment(new Comment("Gamma", "Great talk"));

        // Store the videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display each video and its comments
        foreach (var video in videos)
        {
            Console.WriteLine(video);
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine(comment);
            }
            Console.WriteLine(); // Add a blank line for better readability
        }
    }
}
