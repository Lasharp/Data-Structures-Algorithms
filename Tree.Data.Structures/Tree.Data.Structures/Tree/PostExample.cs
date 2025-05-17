namespace Tree.Data.Structures.Tree
{
    public class PostExample
    {
        private readonly List<Node> Posts;

        public PostExample()
        {
            Posts = [];
        }

        public int AddPost(string content)
        {
            var postId = Posts.Count + 1;
            Posts.Add(new Node
            {
                Id = postId,
                Content = content,
                Children = []
            });

            return postId;
        }

        public Node? GetPost(int id)
        {
            return Posts.FirstOrDefault(p => p.Id == id);
        }

        public int AddComment(int postId, string comment)
        {
            var post = GetPost(postId) ?? throw new ArgumentException($"Post with id {postId} not found.");

            var commentId = post.Children.Count + 1;
            post?.Children.Add(
                new Node
                {
                    Id = commentId,
                    Content = comment,
                    Children = []
                }
            );

            return commentId;
        }

        public int AddReply(int postId, int commentId, string reply)
        {
            var post = GetPost(postId) ?? throw new ArgumentException($"Post with id {postId} not found.");
            var comment = post.Children.FirstOrDefault(c => c.Id == commentId) ?? throw new ArgumentException($"Comment with id {commentId} not found.");

            if (comment.Children.Count >= 10)
                throw new InvalidOperationException("Cannot add more than 10 replies.");

            var replyId = comment.Children.Count + 1;
            comment.Children.Add(
                new Node
                {
                    Id = replyId,
                    Content = reply,
                    Children = []
                }
            );

            return replyId;
        }
    }
}
