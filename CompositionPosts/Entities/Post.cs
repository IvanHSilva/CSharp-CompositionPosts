using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionPosts.Entities {
    public class Post {
        // Attributes
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Conten { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        // Constructors
        public Post() {}

        public Post(DateTime moment, string title, string conten, int likes) {
            Moment = moment;
            Title = title;
            Conten = conten;
            Likes = likes;
        }

        // Methods
        public void AddComment(Comment comment) { 
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment) {
            Comments.Remove(comment);
        }
    }
}
