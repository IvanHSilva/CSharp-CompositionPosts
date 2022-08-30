namespace CompositionPosts.Entities {
    public class Comment {
        // Attributes
        public string Text { get; set; }

        // Constructors
        public Comment() { }

        public Comment(string text) {
            Text = text;
        }
    }
}
