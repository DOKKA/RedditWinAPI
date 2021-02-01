using Reddit;
using Reddit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditWinAPI
{

    public class RedditService
    {
        private RedditClient redditClient;
        public RedditService(Settings settings)
        {
            redditClient = new RedditClient(settings.app_id, settings.refresh_token, settings.app_secret);
        }

        public SubRedditItem[] GetSubReddits(string[] names)
        {
            List<SubRedditItem> items = new List<SubRedditItem>();
            foreach (string name in names)
            {
                Subreddit subreddit = redditClient.Subreddit(name).About();
                SubRedditItem item = new SubRedditItem { Label = subreddit.Name, Name = subreddit.Title, Subreddit = subreddit };
                items.Add(item);
            }
            return items.ToArray();
        }

        public PostItem[] GetTopPosts(SubRedditItem item)
        {
            return item.Subreddit.Posts.Hot
                // .Where(p => p is SelfPost)
                .Select(p => new PostItem { Post = p }).ToArray();
        }


        public CommentNode[] GetCommentNodes(PostItem item)
        {
            List<CommentNode> nodes = new List<CommentNode>();
            foreach (Comment comment in item.Post.Comments.Top)
            {
                CommentNode cn = new CommentNode(comment);
                cn.Nodes.Add("");
                nodes.Add(cn);
            }
            return nodes.ToArray();
        }

        public CommentNode[] GetCommentNodes(CommentNode commentNode)
        {
            List<CommentNode> nodes = new List<CommentNode>();
            foreach (Comment comment in commentNode.Comment.Replies)
            {
                //nodes.Add(new CommentNode(comment));
                CommentNode cn = new CommentNode(comment);
                cn.Nodes.Add("");
                nodes.Add(cn);
            }
            return nodes.ToArray();
        }

    }
}
