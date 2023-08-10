using POOExercicio13.Entities;
using System;
using System.Data;
using System.Globalization;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            DateTime moment1 = DateTime.Parse("21/06/2018 13:05:44");
            string title1 = "Traveling to New Zeeland";
            string content1 = "I'm going to visit this wonderful country!";
            int likes1 = 12;
            Post post1 = new Post(moment1, title1, content1, likes1);

            Comment comment1A = new Comment("Have a nice trip");
            post1.AddComment(comment1A);
            Comment comment1B = new Comment("Wow that's awesome!");
            post1.AddComment(comment1B);

            DateTime moment2 = DateTime.Parse("28/07/2018 23:14:19");
            string title2 = "Good night guys";
            string content2 = "See you tomorrow";
            int likes2 = 5;
            Post post2 = new Post(moment2, title2, content2, likes2);

            Comment comment2A = new Comment("Good night");
            post2.AddComment(comment2A);
            Comment comment2B = new Comment("May the Force be with you");
            post2.AddComment(comment2B);

            Console.WriteLine(post1);
            Console.WriteLine();
            Console.WriteLine(post2);

        }
    }
}