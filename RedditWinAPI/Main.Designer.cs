namespace RedditWinAPI
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.sptOuter = new System.Windows.Forms.SplitContainer();
            this.sptInner = new System.Windows.Forms.SplitContainer();
            this.sptSub = new System.Windows.Forms.SplitContainer();
            this.lbSubs = new System.Windows.Forms.ListBox();
            this.lbPosts = new System.Windows.Forms.ListBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.sptComments = new System.Windows.Forms.SplitContainer();
            this.tvComments = new System.Windows.Forms.TreeView();
            this.txtComment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sptOuter)).BeginInit();
            this.sptOuter.Panel1.SuspendLayout();
            this.sptOuter.Panel2.SuspendLayout();
            this.sptOuter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptInner)).BeginInit();
            this.sptInner.Panel1.SuspendLayout();
            this.sptInner.Panel2.SuspendLayout();
            this.sptInner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptSub)).BeginInit();
            this.sptSub.Panel1.SuspendLayout();
            this.sptSub.Panel2.SuspendLayout();
            this.sptSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptComments)).BeginInit();
            this.sptComments.Panel1.SuspendLayout();
            this.sptComments.Panel2.SuspendLayout();
            this.sptComments.SuspendLayout();
            this.SuspendLayout();
            // 
            // sptOuter
            // 
            this.sptOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptOuter.Location = new System.Drawing.Point(0, 0);
            this.sptOuter.Name = "sptOuter";
            // 
            // sptOuter.Panel1
            // 
            this.sptOuter.Panel1.Controls.Add(this.sptInner);
            // 
            // sptOuter.Panel2
            // 
            this.sptOuter.Panel2.Controls.Add(this.sptComments);
            this.sptOuter.Size = new System.Drawing.Size(784, 561);
            this.sptOuter.SplitterDistance = 500;
            this.sptOuter.TabIndex = 0;
            // 
            // sptInner
            // 
            this.sptInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptInner.Location = new System.Drawing.Point(0, 0);
            this.sptInner.Name = "sptInner";
            this.sptInner.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sptInner.Panel1
            // 
            this.sptInner.Panel1.Controls.Add(this.sptSub);
            // 
            // sptInner.Panel2
            // 
            this.sptInner.Panel2.Controls.Add(this.btnView);
            this.sptInner.Panel2.Controls.Add(this.btnOpen);
            this.sptInner.Panel2.Controls.Add(this.txtBody);
            this.sptInner.Panel2.Controls.Add(this.txtTitle);
            this.sptInner.Size = new System.Drawing.Size(500, 561);
            this.sptInner.SplitterDistance = 249;
            this.sptInner.TabIndex = 0;
            // 
            // sptSub
            // 
            this.sptSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptSub.Location = new System.Drawing.Point(0, 0);
            this.sptSub.Name = "sptSub";
            // 
            // sptSub.Panel1
            // 
            this.sptSub.Panel1.Controls.Add(this.lbSubs);
            // 
            // sptSub.Panel2
            // 
            this.sptSub.Panel2.Controls.Add(this.lbPosts);
            this.sptSub.Size = new System.Drawing.Size(500, 249);
            this.sptSub.SplitterDistance = 150;
            this.sptSub.TabIndex = 0;
            // 
            // lbSubs
            // 
            this.lbSubs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSubs.FormattingEnabled = true;
            this.lbSubs.Location = new System.Drawing.Point(0, 0);
            this.lbSubs.Name = "lbSubs";
            this.lbSubs.Size = new System.Drawing.Size(150, 249);
            this.lbSubs.TabIndex = 0;
            // 
            // lbPosts
            // 
            this.lbPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPosts.FormattingEnabled = true;
            this.lbPosts.Location = new System.Drawing.Point(0, 0);
            this.lbPosts.Name = "lbPosts";
            this.lbPosts.Size = new System.Drawing.Size(346, 249);
            this.lbPosts.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.Location = new System.Drawing.Point(422, 281);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View Link";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpen.Location = new System.Drawing.Point(3, 281);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(104, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open in browser";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // txtBody
            // 
            this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBody.Location = new System.Drawing.Point(3, 26);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBody.Size = new System.Drawing.Size(494, 249);
            this.txtBody.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(3, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(494, 22);
            this.txtTitle.TabIndex = 0;
            // 
            // sptComments
            // 
            this.sptComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptComments.Location = new System.Drawing.Point(0, 0);
            this.sptComments.Name = "sptComments";
            this.sptComments.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sptComments.Panel1
            // 
            this.sptComments.Panel1.Controls.Add(this.tvComments);
            // 
            // sptComments.Panel2
            // 
            this.sptComments.Panel2.Controls.Add(this.txtComment);
            this.sptComments.Size = new System.Drawing.Size(280, 561);
            this.sptComments.SplitterDistance = 300;
            this.sptComments.TabIndex = 0;
            // 
            // tvComments
            // 
            this.tvComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvComments.Location = new System.Drawing.Point(0, 0);
            this.tvComments.Name = "tvComments";
            this.tvComments.Size = new System.Drawing.Size(280, 300);
            this.tvComments.TabIndex = 0;
            // 
            // txtComment
            // 
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComment.Location = new System.Drawing.Point(0, 0);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(280, 257);
            this.txtComment.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.sptOuter);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Main";
            this.Text = "Reddit: The front page of the internet";
            this.sptOuter.Panel1.ResumeLayout(false);
            this.sptOuter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptOuter)).EndInit();
            this.sptOuter.ResumeLayout(false);
            this.sptInner.Panel1.ResumeLayout(false);
            this.sptInner.Panel2.ResumeLayout(false);
            this.sptInner.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptInner)).EndInit();
            this.sptInner.ResumeLayout(false);
            this.sptSub.Panel1.ResumeLayout(false);
            this.sptSub.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptSub)).EndInit();
            this.sptSub.ResumeLayout(false);
            this.sptComments.Panel1.ResumeLayout(false);
            this.sptComments.Panel2.ResumeLayout(false);
            this.sptComments.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptComments)).EndInit();
            this.sptComments.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer sptOuter;
		private System.Windows.Forms.SplitContainer sptInner;
		private System.Windows.Forms.SplitContainer sptSub;
		private System.Windows.Forms.ListBox lbSubs;
		private System.Windows.Forms.ListBox lbPosts;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.TextBox txtBody;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.SplitContainer sptComments;
		private System.Windows.Forms.TreeView tvComments;
		private System.Windows.Forms.TextBox txtComment;
	}
}