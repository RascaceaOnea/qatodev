using System;
using System.Linq;
using System.Windows.Forms;
using NetromMessageBoard.Model;
using NetromMessageBoard.Repository.Interfaces;

namespace NetromMessageBoard
{
    public partial class RegisterForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly IDepartmentRepository _departmentRepository;
        

        public RegisterForm(IUserRepository userRepository, IDepartmentRepository departmentRepository, ICompanyRepository companyRepository)
        {
            InitializeComponent();

            _departmentRepository = departmentRepository;
            _companyRepository = companyRepository;
            _userRepository = userRepository;

            cmbCompany.DataSource = _companyRepository.GetAllCompanies().ToList();
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
                User user = _userRepository.GetAllUsers().FirstOrDefault(u => u.UserName == txtUserName.Text);

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
                    bool succesfullRegister = _userRepository.AddNewUser(txtFirstName.Text, txtLastName.Text,
                        dateTimePickerBirthDate.Value, txtUserName.Text, txtPassword.Text,
                        (Company)cmbCompany.SelectedValue, (Department)cmbDepartment.SelectedValue);

                    if (succesfullRegister)
                    {
                        Hide();
                        new LoginForm().Show();
                    }
                    else
                    {
                        MessageBox.Show("The register failed.", "Error", MessageBoxButtons.OK);
                    }

                    Hide();
                    //new LoginForm().Show();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompany.SelectedValue != null)
            {
                cmbDepartment.DataSource = _departmentRepository.GetAllDepartments()
                    .Where(d => d.CompanyID == ((Company)cmbCompany.SelectedValue).ID);
                cmbDepartment.DisplayMember = "Name";
                cmbDepartment.SelectedIndex = -1;
            }

        }
    }
}
