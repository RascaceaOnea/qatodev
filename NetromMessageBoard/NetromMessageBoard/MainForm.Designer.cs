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
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridUsers)).BeginInit();
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
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(680, 12);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(79, 16);
            this.lblCurrentUser.TabIndex = 1;
            this.lblCurrentUser.Text = "Current user";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(12, 9);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(55, 20);
            this.lblUsers.TabIndex = 2;
            this.lblUsers.Text = "Users:";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.dtaGridUsers);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaGridUsers;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmArrivalDate;
        private System.Windows.Forms.DataGridViewButtonColumn clmBtnDelete;
    }
}