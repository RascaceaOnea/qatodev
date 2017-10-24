namespace NetromMessageBoard
{
    partial class RegisterForm
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
            this.lblRegisterFirstName = new System.Windows.Forms.Label();
            this.lblRegisterLastName = new System.Windows.Forms.Label();
            this.lblRegisterBirthDate = new System.Windows.Forms.Label();
            this.lblRegisterArrivalDate = new System.Windows.Forms.Label();
            this.lblRegisterUserName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtArrivalDate = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUserNameAlreadyExists = new System.Windows.Forms.Label();
            this.txtRepreatPassword = new System.Windows.Forms.TextBox();
            this.lblRegisterRptPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.lblPasswordMismatch = new System.Windows.Forms.Label();
            this.lblAllFieldsAreMandatory = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegisterFirstName
            // 
            this.lblRegisterFirstName.AutoSize = true;
            this.lblRegisterFirstName.Location = new System.Drawing.Point(5, 22);
            this.lblRegisterFirstName.Name = "lblRegisterFirstName";
            this.lblRegisterFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblRegisterFirstName.TabIndex = 0;
            this.lblRegisterFirstName.Text = "First Name";
            // 
            // lblRegisterLastName
            // 
            this.lblRegisterLastName.AutoSize = true;
            this.lblRegisterLastName.Location = new System.Drawing.Point(5, 43);
            this.lblRegisterLastName.Name = "lblRegisterLastName";
            this.lblRegisterLastName.Size = new System.Drawing.Size(58, 13);
            this.lblRegisterLastName.TabIndex = 1;
            this.lblRegisterLastName.Text = "Last Name";
            // 
            // lblRegisterBirthDate
            // 
            this.lblRegisterBirthDate.AutoSize = true;
            this.lblRegisterBirthDate.Location = new System.Drawing.Point(5, 64);
            this.lblRegisterBirthDate.Name = "lblRegisterBirthDate";
            this.lblRegisterBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblRegisterBirthDate.TabIndex = 2;
            this.lblRegisterBirthDate.Text = "Birth Date";
            // 
            // lblRegisterArrivalDate
            // 
            this.lblRegisterArrivalDate.AutoSize = true;
            this.lblRegisterArrivalDate.Location = new System.Drawing.Point(5, 85);
            this.lblRegisterArrivalDate.Name = "lblRegisterArrivalDate";
            this.lblRegisterArrivalDate.Size = new System.Drawing.Size(62, 13);
            this.lblRegisterArrivalDate.TabIndex = 3;
            this.lblRegisterArrivalDate.Text = "Arrival Date";
            // 
            // lblRegisterUserName
            // 
            this.lblRegisterUserName.AutoSize = true;
            this.lblRegisterUserName.Location = new System.Drawing.Point(5, 22);
            this.lblRegisterUserName.Name = "lblRegisterUserName";
            this.lblRegisterUserName.Size = new System.Drawing.Size(57, 13);
            this.lblRegisterUserName.TabIndex = 4;
            this.lblRegisterUserName.Text = "UserName";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(75, 19);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(203, 20);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(75, 40);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(203, 20);
            this.txtLastName.TabIndex = 10;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(75, 61);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(203, 20);
            this.txtBirthDate.TabIndex = 11;
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Location = new System.Drawing.Point(75, 82);
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(203, 20);
            this.txtArrivalDate.TabIndex = 12;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(98, 19);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(203, 20);
            this.txtUserName.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAllFieldsAreMandatory);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblRegisterFirstName);
            this.groupBox1.Controls.Add(this.txtArrivalDate);
            this.groupBox1.Controls.Add(this.lblRegisterLastName);
            this.groupBox1.Controls.Add(this.txtBirthDate);
            this.groupBox1.Controls.Add(this.lblRegisterBirthDate);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.lblRegisterArrivalDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 110);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPasswordMismatch);
            this.groupBox2.Controls.Add(this.lblUserNameAlreadyExists);
            this.groupBox2.Controls.Add(this.txtRepreatPassword);
            this.groupBox2.Controls.Add(this.lblRegisterRptPassword);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.lblRegisterPassword);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.lblRegisterUserName);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 97);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add user and password";
            // 
            // lblUserNameAlreadyExists
            // 
            this.lblUserNameAlreadyExists.AutoSize = true;
            this.lblUserNameAlreadyExists.ForeColor = System.Drawing.Color.Red;
            this.lblUserNameAlreadyExists.Location = new System.Drawing.Point(308, 22);
            this.lblUserNameAlreadyExists.Name = "lblUserNameAlreadyExists";
            this.lblUserNameAlreadyExists.Size = new System.Drawing.Size(95, 13);
            this.lblUserNameAlreadyExists.TabIndex = 18;
            this.lblUserNameAlreadyExists.Text = "User already exists";
            this.lblUserNameAlreadyExists.Visible = false;
            // 
            // txtRepreatPassword
            // 
            this.txtRepreatPassword.Location = new System.Drawing.Point(98, 67);
            this.txtRepreatPassword.Name = "txtRepreatPassword";
            this.txtRepreatPassword.Size = new System.Drawing.Size(203, 20);
            this.txtRepreatPassword.TabIndex = 17;
            // 
            // lblRegisterRptPassword
            // 
            this.lblRegisterRptPassword.AutoSize = true;
            this.lblRegisterRptPassword.Location = new System.Drawing.Point(6, 70);
            this.lblRegisterRptPassword.Name = "lblRegisterRptPassword";
            this.lblRegisterRptPassword.Size = new System.Drawing.Size(91, 13);
            this.lblRegisterRptPassword.TabIndex = 16;
            this.lblRegisterRptPassword.Text = "Repeat Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(98, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(203, 20);
            this.txtPassword.TabIndex = 15;
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Location = new System.Drawing.Point(5, 48);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(53, 13);
            this.lblRegisterPassword.TabIndex = 14;
            this.lblRegisterPassword.Text = "Password";
            // 
            // lblPasswordMismatch
            // 
            this.lblPasswordMismatch.AutoSize = true;
            this.lblPasswordMismatch.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordMismatch.Location = new System.Drawing.Point(308, 70);
            this.lblPasswordMismatch.Name = "lblPasswordMismatch";
            this.lblPasswordMismatch.Size = new System.Drawing.Size(100, 13);
            this.lblPasswordMismatch.TabIndex = 19;
            this.lblPasswordMismatch.Text = "Password mismatch";
            this.lblPasswordMismatch.Visible = false;
            // 
            // lblAllFieldsAreMandatory
            // 
            this.lblAllFieldsAreMandatory.AutoSize = true;
            this.lblAllFieldsAreMandatory.ForeColor = System.Drawing.Color.Red;
            this.lblAllFieldsAreMandatory.Location = new System.Drawing.Point(293, 47);
            this.lblAllFieldsAreMandatory.Name = "lblAllFieldsAreMandatory";
            this.lblAllFieldsAreMandatory.Size = new System.Drawing.Size(115, 13);
            this.lblAllFieldsAreMandatory.TabIndex = 19;
            this.lblAllFieldsAreMandatory.Text = "All fields are mandatory";
            this.lblAllFieldsAreMandatory.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 230);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRegisterFirstName;
        private System.Windows.Forms.Label lblRegisterLastName;
        private System.Windows.Forms.Label lblRegisterBirthDate;
        private System.Windows.Forms.Label lblRegisterArrivalDate;
        private System.Windows.Forms.Label lblRegisterUserName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtArrivalDate;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRepreatPassword;
        private System.Windows.Forms.Label lblRegisterRptPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label lblUserNameAlreadyExists;
        private System.Windows.Forms.Label lblPasswordMismatch;
        private System.Windows.Forms.Label lblAllFieldsAreMandatory;
    }
}