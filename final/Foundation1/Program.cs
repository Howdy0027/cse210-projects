// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store Video objects
        List<Video> videos = new List<Video>();

        // Create Video objects with title, author, and length (in seconds)
        Video video1 = new Video("Understanding C#", "John Doe", 600);
        Video video2 = new Video("Learning Python", "Jane Smith", 900);
        Video video3 = new Video("JavaScript Basics", "Bob Johnson", 300);

        // Add comments to the first video
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));

        // Add comments to the second video
        video2.AddComment(new Comment("Dave", "Awesome content!"));
        video2.AddComment(new Comment("Eve", "Thank you for the detailed explanation."));
        video2.AddComment(new Comment("Frank", "Well explained."));

        // Add comments to the third video
        video3.AddComment(new Comment("Grace", "Short and sweet!"));
        video3.AddComment(new Comment("Hank", "Perfect for beginners."));
        video3.AddComment(new Comment("Ivy", "I love this tutorial."));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Iterate through the list of videos and display their details
        foreach (var video in videos)
        {
            // Display the title, author, and length of the video
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");

            // Display the number of comments using the method from the Video class
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            // Iterate through the list of comments for the current video and display each one
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            // Add an empty line for better readability between video details
            Console.WriteLine();
        }
    }
}