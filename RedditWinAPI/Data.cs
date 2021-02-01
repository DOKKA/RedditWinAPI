using Reddit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedditWinAPI
{
    public class Data
    {
    }

    public class SubRedditItem
    {

        public string Label { get; set; }

        public string Name { get; set; }

        public Subreddit Subreddit { get; set; }

        public override string ToString()
        {
            return this.Label;
        }
    }

    public class PostItem
    {
        public Post Post { get; set; }

        public override string ToString()
        {
            return this.Post.Title;
        }
    }

    public class CommentNode : TreeNode
    {
        public Comment Comment { get; set; }

        public CommentNode(Comment comment)
        {
            this.Text = comment.Body;
            this.Nodes.AddRange(new TreeNode[] { });
            this.Comment = comment;
        }


    }
}
