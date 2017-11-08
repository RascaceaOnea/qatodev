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
            this.lblRegisterUserName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblAllFieldsAreMandatory = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPasswordMismatch = new System.Windows.Forms.Label();
            this.lblUserNameAlreadyExists = new System.Windows.Forms.Label();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.lblRegisterRptPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
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
            this.lblRegisterLastName.Location = new System.Drawing.Point(5, 44);
            this.lblRegisterLastName.Name = "lblRegisterLastName";
            this.lblRegisterLastName.Size = new System.Drawing.Size(58, 13);
            this.lblRegisterLastName.TabIndex = 1;
            this.lblRegisterLastName.Text = "Last Name";
            // 
            // lblRegisterBirthDate
            // 
            this.lblRegisterBirthDate.AutoSize = true;
            this.lblRegisterBirthDate.Location = new System.Drawing.Point(5, 66);
            this.lblRegisterBirthDate.Name = "lblRegisterBirthDate";
            this.lblRegisterBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblRegisterBirthDate.TabIndex = 2;
            this.lblRegisterBirthDate.Text = "Birth Date";
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
            this.txtLastName.Location = new System.Drawing.Point(75, 41);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(203, 20);
            this.txtLastName.TabIndex = 10;
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
            this.groupBox1.Controls.Add(this.cmbDepartment);
            this.groupBox1.Controls.Add(this.cmbCompany);
            this.groupBox1.Controls.Add(this.lblDepartment);
            this.groupBox1.Controls.Add(this.lblCompany);
            this.groupBox1.Controls.Add(this.dateTimePickerBirthDate);
            this.groupBox1.Controls.Add(this.lblAllFieldsAreMandatory);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblRegisterFirstName);
            this.groupBox1.Controls.Add(this.lblRegisterLastName);
            this.groupBox1.Controls.Add(this.lblRegisterBirthDate);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 152);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Data";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(75, 108);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(203, 21);
            this.cmbDepartment.TabIndex = 24;
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(75, 85);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(203, 21);
            this.cmbCompany.TabIndex = 23;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(5, 110);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 22;
            this.lblDepartment.Text = "Department";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(5, 88);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 21;
            this.lblCompany.Text = "Company";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(75, 63);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(203, 20);
            this.dateTimePickerBirthDate.TabIndex = 20;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPasswordMismatch);
            this.groupBox2.Controls.Add(this.lblUserNameAlreadyExists);
            this.groupBox2.Controls.Add(this.txtRepeatPassword);
            this.groupBox2.Controls.Add(this.lblRegisterRptPassword);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.lblRegisterPassword);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.lblRegisterUserName);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 97);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add user and password";
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
            this.txtRepeatPassword.Location = new System.Drawing.Point(98, 67);
            this.txtRepeatPassword.Name = "txtRepreatPassword";
            this.txtRepeatPassword.Size = new System.Drawing.Size(203, 20);
            this.txtRepeatPassword.TabIndex = 17;
            this.txtRepeatPassword.UseSystemPasswordChar = true;
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
            this.txtPassword.UseSystemPasswordChar = true;
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
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(353, 275);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 310);
            this.Controls.Add(this.btnSubmit);
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
        private System.Windows.Forms.Label lblRegisterUserName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.Label lblRegisterRptPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label lblUserNameAlreadyExists;
        private System.Windows.Forms.Label lblPasswordMismatch;
        private System.Windows.Forms.Label lblAllFieldsAreMandatory;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbCompany;
    }
}