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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewTopics
            // 
            this.listViewTopics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.TopicTitle,
            this.TopicDescription,
            this.TopicOwner});
            this.listViewTopics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTopics.Location = new System.Drawing.Point(0, 0);
            this.listViewTopics.Name = "listViewTopics";
            this.listViewTopics.Size = new System.Drawing.Size(584, 336);
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
            this.txtCurrentUser.AutoSize = true;
            this.txtCurrentUser.Location = new System.Drawing.Point(537, 9);
            this.txtCurrentUser.Name = "txtCurrentUser";
            this.txtCurrentUser.Size = new System.Drawing.Size(35, 13);
            this.txtCurrentUser.TabIndex = 1;
            this.txtCurrentUser.Text = "User: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCurrentUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 30);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewTopics);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 336);
            this.panel2.TabIndex = 3;
            // 
            // TopicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "TopicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select a topic";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTopics;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader TopicTitle;
        private System.Windows.Forms.ColumnHeader TopicDescription;
        private System.Windows.Forms.ColumnHeader TopicOwner;
        private System.Windows.Forms.Label txtCurrentUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}