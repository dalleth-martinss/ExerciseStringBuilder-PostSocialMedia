using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ExerciceStringBuilderPostSocialMedia.Entities;

namespace ExerciceStringBuilderPostSocialMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip ");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 22:08:58"),
                "Traveling to new Zealand",
                "I'm going to visit this wonderful country! ",
                12
                );

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good evening!");
            Comment c4 = new Comment("May the Force be with you ");
            Post p2 = new Post(
                DateTime.Parse("28/07/2024  22:13:51"),
                "I'll to sleep now ",
                "See you tomorrow",
                5);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            



            Console.ReadLine();

        }
    }
}
