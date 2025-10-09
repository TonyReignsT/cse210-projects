using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        // Create videos
        Video video1 = new Video();
        video1._title = "Learn C# in 10 Minutes";
        video1._author = "Antony Ochieng";
        video1._length = 600;

        Video video2 = new Video();
        video2._title = "Intro to React";
        video2._author = "CodeWithAntony";
        video2._length = 720;

        Video video3 = new Video();
        video3._title = "Networking Basics";
        video3._author = "TechToni";
        video3._length = 540;

        // Create and add comments
        Comment c1 = new Comment();
        c1._name = "John";
        c1._text = "Very helpful!";
        video1.AddComment(c1);

        Comment c2 = new Comment();
        c2._name = "Sarah";
        c2._text = "Loved this explanation.";
        video1.AddComment(c2);

        Comment c3 = new Comment();
        c3._name = "Mike";
        c3._text = "Please make a part 2!";
        video1.AddComment(c3);

        Comment c4 = new Comment();
        c4._name = "Alice";
        c4._text = "React finally makes sense.";
        video2.AddComment(c4);

        Comment c5 = new Comment();
        c5._name = "Brian";
        c5._text = "Subscribed!";
        video2.AddComment(c5);

        Comment c6 = new Comment();
        c6._name = "Lucy";
        c6._text = "Please cover hooks next.";
        video2.AddComment(c6);

        Comment c7 = new Comment();
        c7._name = "David";
        c7._text = "Nice and simple.";
        video3.AddComment(c7);

        Comment c8 = new Comment();
        c8._name = "Emma";
        c8._text = "Thanks for this.";
        video3.AddComment(c8);

        Comment c9 = new Comment();
        c9._name = "Chris";
        c9._text = "Good job explaining.";
        video3.AddComment(c9);

        // Store all videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display info
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}