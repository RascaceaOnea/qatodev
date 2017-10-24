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
        public RegisterForm()
        {
            InitializeComponent();

            var context = new QaToDevEntities();
            cmbCompany.DataSource = context.Companies.ToList();
            cmbCompany.ValueMember = "ID";
            cmbCompany.DisplayMember = "Name";

            cmbDepartment.DataSource = context.Departments.Where(d => d.CompanyID == (int) cmbCompany.SelectedValue).ToList();
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.DisplayMember = "Name";
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblAllFieldsAreMandatory.Hide();
            lblUserNameAlreadyExists.Hide();
            lblPasswordMismatch.Hide();

            using (QaToDevEntities context = new QaToDevEntities())
            {
                if (txtFirstName.Text == "" || txtLastName.Text == null || txtUserName.Text == "" || txtPassword.Text == "" || txtRepreatPassword.Text == "")
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
                        validUser.UserPassword = txtPassword.Text;


                        
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

        }
    }
}
