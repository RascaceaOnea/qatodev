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
using NetromMessageBoard.Model;
using NetromMessageBoard.Repository;

namespace NetromMessageBoard
{
    public partial class RegisterForm : Form
    {
        protected NetromMessageBoardEntities Context { get; private set; }

        public RegisterForm()
        {
            InitializeComponent();
            Context = new NetromMessageBoardEntities();

            cmbCompany.DataSource = Context.Companies.ToList();
            cmbCompany.DisplayMember = "Name";
            cmbCompany.SelectedIndex = -1;
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblAllFieldsAreMandatory.Hide();
            lblUserNameAlreadyExists.Hide();
            lblPasswordMismatch.Hide();

            using (NetromMessageBoardEntities context = new NetromMessageBoardEntities())
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
                        bool succesfullRegister =  new UserRepository().AddNewUser(txtFirstName.Text, txtLastName.Text,
                            dateTimePickerBirthDate.Value, txtUserName.Text, txtPassword.Text,
                            (Company) cmbCompany.SelectedValue, (Department) cmbDepartment.SelectedValue);

                        if (succesfullRegister)
                        {
                            this.Hide();
                            new LoginForm().Show();
                        }
                        else
                        {
                            MessageBox.Show("The register failed.", "Error", MessageBoxButtons.OK);
                        }

                        this.Hide();
                        //new LoginForm().Show();
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
