using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C#","Alice", 600 );
        video1.AddComment(new Comment("John", "Great explaination!"));
        video1.AddComment(new Comment("Mary", "Very helpful thanks"));
        video1.AddComment(new Comment("Sam", "Can you give us the link?"));
        videos.Add(video1);


        Video video2 = new Video("Travel Vlog: Paris", "Sophia", 900);
        video2.AddComment(new Comment("Chris", "Beautiful shots"));
        video2.AddComment(new Comment("Ella", "I want to visit someday."));
        video2.AddComment(new Comment("Tom", "What camera are you using?"));
        videos.Add(video2);

        Video video3 = new Video("Cocking Pasta", "Chef Mike", 300);
        video3.AddComment(new Comment("Anna", "Looks delicious"));
        video3.AddComment(new Comment("Leo", "I tried this recipe, amazing."));
        video3.AddComment(new Comment("Nina", "Can you share a vegeterian version?"));
        videos.Add(video3);


        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }




    }
}