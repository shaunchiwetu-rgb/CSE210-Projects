using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the first video
        Video video1 = new Video("Learning C#", "Shaun Code", 600);

        video1.AddComment(new Comment("Mary", "Great tutorial!"));
        video1.AddComment(new Comment("Peter", "Very helpful video."));
        video1.AddComment(new Comment("Sarah", "I learned something new."));
        video1.AddComment(new Comment("David", "Keep making more videos!"));

        // Create the second video
        Video video2 = new Video("Introduction to Python", "Tech Academy", 900);

        video2.AddComment(new Comment("James", "Python is interesting."));
        video2.AddComment(new Comment("Linda", "Thanks for explaining this."));
        video2.AddComment(new Comment("Michael", "Very informative!"));

        // Create the third video
        Video video3 = new Video("Web Development Basics", "Code Master", 750);

        video3.AddComment(new Comment("Anna", "Excellent explanation."));
        video3.AddComment(new Comment("Robert", "This helped me a lot."));
        video3.AddComment(new Comment("Grace", "Looking forward to the next lesson."));
        video3.AddComment(new Comment("Daniel", "Amazing content!"));

        // Store all videos in a list
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine("==============================");
            video.DisplayVideo();
            Console.WriteLine("==============================");
            Console.WriteLine();
        }
    }
}
