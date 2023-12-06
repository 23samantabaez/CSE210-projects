using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("VIDEOS: ");
        Console.WriteLine();
        
        // Video objects
        Video video1 = new Video("Product Honest Review", "Mike Jacobs", 120);
        Video video2 = new Video("The only product you'll ever need!", "Larry Harness", 180);
        Video video3 = new Video("Product reaction, first impressions!", "Bill Baker", 150);

        // Adding comments to videos
        video1.AddComment("User329", "Love it!");
        video1.AddComment("UserCutiePie", "Great Video");
        video1.AddComment("UserHIHI", "I agree!");

        video2.AddComment("User89", "Amazing!");
        video2.AddComment("UserLOL", "Very entertaining");

        video3.AddComment("User62", "Nice video");
        video3.AddComment("UserPinky", "Thanks for sharing");
        video3.AddComment("User2003", "I will buy it!");

        List<Video> videos = new List<Video> { video1, video2, video3 };  // Adding videos to list


        foreach (var video in videos) // Display vid info
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

            Console.WriteLine(); // Separation
        }
    }
}



