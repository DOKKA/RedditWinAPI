using Reddit.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedditWinAPI
{
	public partial class Main : Form
	{
		RedditService rs;
		public Main()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			ConfigRoot config = ConfigService.GetConfig();

			tvComments.BeforeExpand += TvComments_BeforeExpand;
			tvComments.AfterSelect += TvComments_AfterSelect;
			lbSubs.SelectedIndexChanged += lbSubs_SelectedIndexChanged;
			lbPosts.SelectedIndexChanged += lbPosts_SelectedIndexChanged;


			rs = new RedditService(config.settings);
			SubRedditItem[] subs = rs.GetSubReddits(config.preferences.subreddits.ToArray());
			lbSubs.Items.AddRange(subs);
		}

		private void TvComments_AfterSelect(object sender, TreeViewEventArgs e)
		{
			txtComment.Text = e.Node.Text;
		}

		private void TvComments_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			e.Node.Nodes.Clear();
			CommentNode[] nodes = rs.GetCommentNodes((CommentNode)e.Node);
			e.Node.Nodes.AddRange(nodes);
		}

		private void lbSubs_SelectedIndexChanged(object sender, EventArgs e)
		{
			lbPosts.Items.Clear();
			tvComments.Nodes.Clear();
			txtBody.Text = "";
			txtTitle.Text = "";
			if (lbSubs.SelectedItems.Count > 0)
			{
				SubRedditItem item = (SubRedditItem)lbSubs.SelectedItems[0];
				PostItem[] items = rs.GetTopPosts(item);
				lbPosts.Items.AddRange(items);
			}
		}

		private void lbPosts_SelectedIndexChanged(object sender, EventArgs e)
		{
			tvComments.Nodes.Clear();
			if (lbPosts.SelectedItems.Count > 0)
			{
				PostItem item = (PostItem)lbPosts.SelectedItems[0];
				txtTitle.Text = item.Post.Title;

				if (item.Post.GetType() == typeof(SelfPost))
				{
					txtBody.Text = ((SelfPost)item.Post).SelfText.Replace("\n", Environment.NewLine);
				}
				else
				{
					txtBody.Text = item.Post.GetType().FullName;
				}

				tvComments.Nodes.AddRange(rs.GetCommentNodes(item));
			}
		}
	}
}
