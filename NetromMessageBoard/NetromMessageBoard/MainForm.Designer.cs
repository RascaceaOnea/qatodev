namespace NetromMessageBoard
{
    partial class MainForm
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
            this.dtaGridUsers = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.topicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtaGridUsers
            // 
            this.dtaGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmUserName,
            this.clmUserFullName,
            this.clmCompany,
            this.clmDepartment,
            this.clmBirthDate,
            this.clmArrivalDate,
            this.clmBtnDelete});
            this.dtaGridUsers.Location = new System.Drawing.Point(12, 37);
            this.dtaGridUsers.Name = "dtaGridUsers";
            this.dtaGridUsers.Size = new System.Drawing.Size(760, 462);
            this.dtaGridUsers.TabIndex = 0;
            this.dtaGridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaGridUsers_CellContentClick);
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.Visible = false;
            // 
            // clmUserName
            // 
            this.clmUserName.HeaderText = "Username";
            this.clmUserName.Name = "clmUserName";
            this.clmUserName.ReadOnly = true;
            this.clmUserName.Width = 85;
            // 
            // clmUserFullName
            // 
            this.clmUserFullName.HeaderText = "Name";
            this.clmUserFullName.Name = "clmUserFullName";
            this.clmUserFullName.ReadOnly = true;
            this.clmUserFullName.Width = 130;
            // 
            // clmCompany
            // 
            this.clmCompany.HeaderText = "Company";
            this.clmCompany.Name = "clmCompany";
            this.clmCompany.ReadOnly = true;
            // 
            // clmDepartment
            // 
            this.clmDepartment.HeaderText = "Department";
            this.clmDepartment.Name = "clmDepartment";
            this.clmDepartment.ReadOnly = true;
            // 
            // clmBirthDate
            // 
            this.clmBirthDate.HeaderText = "Birth Date";
            this.clmBirthDate.Name = "clmBirthDate";
            this.clmBirthDate.ReadOnly = true;
            // 
            // clmArrivalDate
            // 
            this.clmArrivalDate.HeaderText = "Arrival Date";
            this.clmArrivalDate.Name = "clmArrivalDate";
            this.clmArrivalDate.ReadOnly = true;
            // 
            // clmBtnDelete
            // 
            this.clmBtnDelete.DataPropertyName = "Delete user";
            this.clmBtnDelete.HeaderText = "Delete";
            this.clmBtnDelete.Name = "clmBtnDelete";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.topicToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(47, 23);
            this.toolStripMenuItem1.Text = "Users";
            // 
            // topicToolStripMenuItem
            // 
            this.topicToolStripMenuItem.Name = "topicToolStripMenuItem";
            this.topicToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.topicToolStripMenuItem.Text = "Topic";
            this.topicToolStripMenuItem.Click += new System.EventHandler(this.topicToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.dtaGridUsers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaGridUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmArrivalDate;
        private System.Windows.Forms.DataGridViewButtonColumn clmBtnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem topicToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}