using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comment { get; set; } = new List<Comment>();

        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comment.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comment.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes -");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach(Comment c in Comment)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
          
        }

        static void Main()
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            Post p1 = new Post { 
                Moment = DateTime.Parse("21/06/2018 13:05:44"),
                Title="Traveling to New Zealand",
                Content = "I'm going to visit this wonderful country!",
                Likes = 12
            };

            Post p2 = new Post
            {
                Moment = DateTime.Parse("28/07/2018 23:14:19"),
                Title = "God night guys",
                Content = "See you tomorrow",
                Likes = 5
            };


            p1.AddComment(c1);
            p1.AddComment(c2);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }

    }
}
