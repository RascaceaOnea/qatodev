namespace NetromMessageBoard
{
    partial class TopicForm
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
            this.listViewTopics = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopicTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopicDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopicOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCurrentUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewTopics
            // 
            this.listViewTopics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTopics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.TopicTitle,
            this.TopicDescription,
            this.TopicOwner});
            this.listViewTopics.Location = new System.Drawing.Point(12, 40);
            this.listViewTopics.Name = "listViewTopics";
            this.listViewTopics.Size = new System.Drawing.Size(560, 309);
            this.listViewTopics.TabIndex = 0;
            this.listViewTopics.UseCompatibleStateImageBehavior = false;
            this.listViewTopics.View = System.Windows.Forms.View.Details;
            this.listViewTopics.SelectedIndexChanged += new System.EventHandler(this.listViewTopics_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // TopicTitle
            // 
            this.TopicTitle.Text = "Title";
            this.TopicTitle.Width = 132;
            // 
            // TopicDescription
            // 
            this.TopicDescription.Text = "Description";
            this.TopicDescription.Width = 255;
            // 
            // TopicOwner
            // 
            this.TopicOwner.Text = "Topic owner";
            this.TopicOwner.Width = 109;
            // 
            // txtCurrentUser
            // 
            this.txtCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentUser.AutoSize = true;
            this.txtCurrentUser.Location = new System.Drawing.Point(537, 13);
            this.txtCurrentUser.Name = "txtCurrentUser";
            this.txtCurrentUser.Size = new System.Drawing.Size(35, 13);
            this.txtCurrentUser.TabIndex = 1;
            this.txtCurrentUser.Text = "User: ";
            // 
            // TopicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.txtCurrentUser);
            this.Controls.Add(this.listViewTopics);
            this.Name = "TopicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select a topic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewTopics;
        private System.Windows.Forms.Label txtCurrentUser;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader TopicTitle;
        private System.Windows.Forms.ColumnHeader TopicDescription;
        private System.Windows.Forms.ColumnHeader TopicOwner;
    }
}