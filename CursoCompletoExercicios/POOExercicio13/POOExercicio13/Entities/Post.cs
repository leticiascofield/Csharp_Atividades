using POOExercicio13.Entities;
using System;


namespace POOExercicio13.Entities {
    internal class Post {

        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }

        public Post(DateTime moment, string title, string content, int likes) {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment) {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment) {  
            Comments.Remove(comment); 
        }

        public override string ToString() {
            Console.WriteLine(Title);
            Console.WriteLine(Likes + " Likes - " + Moment);
            Console.WriteLine(Content);
            Console.WriteLine("Comments:");
            foreach (Comment comment in Comments) {
                Console.WriteLine(comment);
            }
            return "";
        }
    }
}
