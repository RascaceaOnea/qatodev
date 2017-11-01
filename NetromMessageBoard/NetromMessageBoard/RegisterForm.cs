using System;
using System.Linq;
using System.Windows.Forms;
using NetromMessageBoard.Model;
using NetromMessageBoard.Repository;
using NetromMessageBoard.Repository.Interfaces;

namespace NetromMessageBoard
{
    public partial class RegisterForm : Form
    {
        private const string TheRegisterFailed = "The register failed.";
        private const string Caption = "Error";

        public RegisterForm()
        {
            InitializeComponent();

            var companyRepository = UnitOfWork.Instance.GetRepository<ICompanyRepository>();
            
            cmbCompany.DataSource = companyRepository.GetAllCompanies().ToList();
            cmbCompany.DisplayMember = "Name";
            cmbCompany.SelectedIndex = -1;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblAllFieldsAreMandatory.Hide();
            lblUserNameAlreadyExists.Hide();
            lblPasswordMismatch.Hide();

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
                var userRepository = UnitOfWork.Instance.GetRepository<IUserRepository>();

                User user = userRepository.GetAllUsers().FirstOrDefault(u => u.UserName == txtUserName.Text);

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
                    bool succesfullRegister = userRepository.AddNewUser(txtFirstName.Text, txtLastName.Text,
                        dateTimePickerBirthDate.Value, txtUserName.Text, txtPassword.Text,
                        (Company)cmbCompany.SelectedValue, (Department)cmbDepartment.SelectedValue);

                    if (succesfullRegister)
                    {
                        Hide();
                        new LoginForm().Show();
                    }
                    else
                    {
                        MessageBox.Show(TheRegisterFailed, Caption, MessageBoxButtons.OK);
                    }

                    Hide();
                    new LoginForm().Show();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompany.SelectedValue != null)
            {
                var departmentRepository = UnitOfWork.Instance.GetRepository<IDepartmentRepository>();
                cmbDepartment.DataSource = departmentRepository.GetAllDepartments()
                    .Where(d => d.CompanyID == ((Company)cmbCompany.SelectedValue).ID).ToList();
                cmbDepartment.DisplayMember = "Name";
                cmbDepartment.SelectedIndex = -1;
            }

        }
    }
}
