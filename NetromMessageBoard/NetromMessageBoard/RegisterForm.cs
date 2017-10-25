using NetromMessageBoard.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetromMessageBoard
{
    public partial class RegisterForm : Form
    {
        protected QaToDevEntities Context { get; private set; }

        public RegisterForm()
        {
            InitializeComponent();

            Context = new QaToDevEntities();
            cmbCompany.DataSource = Context.Companies.ToList();
            cmbCompany.DisplayMember = "Name";
            cmbCompany.SelectedIndex = -1;
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblAllFieldsAreMandatory.Hide();
            lblUserNameAlreadyExists.Hide();
            lblPasswordMismatch.Hide();

            using (QaToDevEntities context = new QaToDevEntities())
            {
                
                if (string.IsNullOrEmpty(txtFirstName.Text)
                    || string.IsNullOrEmpty(txtLastName.Text)
                    || string.IsNullOrEmpty(txtUserName.Text)
                    || string.IsNullOrEmpty(txtPassword.Text)
                    || string.IsNullOrEmpty(txtRepreatPassword.Text)
                    || string.IsNullOrEmpty(((Company)cmbCompany.SelectedValue).Name)
                    || string.IsNullOrEmpty(((Department)cmbDepartment.SelectedValue).Name))
                {
                    lblAllFieldsAreMandatory.Show();
                }
                else
                {
                    User user = context.Users.FirstOrDefault(u => u.UserName == txtUserName.Text);

                    if (user != null)
                    {
                        lblUserNameAlreadyExists.Show();
                    }
                    else if (txtPassword.Text != txtRepreatPassword.Text)
                    {
                        lblPasswordMismatch.Show();
                    }
                    else
                    {
                        User validUser = new User();

                        validUser.FirstName = txtFirstName.Text;
                        validUser.LastName = txtLastName.Text;
                        validUser.BirthDate = dateTimePickerBirthDate.Value.Date;
                        validUser.ArrivalDate = DateTime.Now.Date;
                        validUser.UserName = txtUserName.Text;

                        byte[] data = System.Text.Encoding.ASCII.GetBytes(txtPassword.Text);
                        data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                        String hash = System.Text.Encoding.ASCII.GetString(data);

                        validUser.UserPassword = hash;
                        validUser.CompanyID = ((Company)cmbCompany.SelectedValue).ID;
                        validUser.DepartmentID = ((Department)cmbDepartment.SelectedValue).ID;
                        
                        context.Users.Add(validUser);
                        context.SaveChanges();

                        this.Hide();
                        new LoginForm().Show();
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompany.SelectedValue != null)
            {
                cmbDepartment.DataSource = Context.Departments.Where(d => d.CompanyID == ((Company)cmbCompany.SelectedValue).ID).ToList();
                cmbDepartment.DisplayMember = "Name";
                cmbDepartment.SelectedIndex = -1;
            }

        }
    }
}
