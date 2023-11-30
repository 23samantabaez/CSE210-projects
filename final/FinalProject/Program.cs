using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello FinalProject World!");
        // Creating Video objects
        Video video1 = new Video("Title 1", "Author 1", 120);
        Video video2 = new Video("Title 2", "Author 2", 180);
        Video video3 = new Video("Title 3", "Author 3", 150);

        // Adding comments to videos
        video1.AddComment("UserA", "Comment 1 for Video 1");
        video1.AddComment("UserB", "Comment 2 for Video 1");
        video1.AddComment("UserC", "Comment 3 for Video 1");

        video2.AddComment("UserX", "Comment 1 for Video 2");
        video2.AddComment("UserY", "Comment 2 for Video 2");

        video3.AddComment("UserP", "Comment 1 for Video 3");
        video3.AddComment("UserQ", "Comment 2 for Video 3");
        video3.AddComment("UserR", "Comment 3 for Video 3");

        // Adding videos to a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displaying information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.UserName}: {comment.Text}");
            }

            Console.WriteLine(); // Separating each video's details
        }
    }
}