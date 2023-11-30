using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        //video objects
        Video _video1 = new Video("Title vid 1", "Author vid 1", 180);
        Video _video2 = new Video("Title vid 2", "Author vid 2", 150);
        Video _video3 = new Video("Title vid 3", "Author vid 3", 175);
            
        //comments
        _video1.AddComment("Commenter 1A", "This is comment 1A");
        _video1.AddComment("Commenter 1B", "This is comment 1B");
        _video1.AddComment("Commenter 1C", "This is comment 1C");

        _video2.AddComment("Commenter 2A", "This is comment 2A");
        _video2.AddComment("Commenter 2B", "This is comment 2B");
        _video2.AddComment("Commenter 2C", "This is comment 2C");

        _video3.AddComment("Commenter 3A", "This is comment 3A");
        _video3.AddComment("Commenter 3B", "This is comment 3B");
        _video3.AddComment("Commenter 3C", "This is comment 3C");

        //List
        List<Video> videosList = new List<Video> {_video1, _video2, _video3};

        //Iterate through the videos and display their info
        foreach (var video in videosList)
        {
            Console.WriteLine($"Title: {video._title}"); //Video Title
            Console.WriteLine($"Author: {video._author}"); //Author
            Console.WriteLine($"Length: {video._length}"); //Length
            Console.WriteLine($"Comments: "); //Comments
            this.commentsList = commentsList; //foreach (var comment in video.commentsList) this.commentsList = commentsList;
            {
                Console.WriteLine($"{_commenterName} - {_commentContent}");
            }
            Console.WriteLine();
        }
        
        Console.ReadLine(); // Keeps the console window open (optional)
    }
}



