using System;
using System.Linq;
using System.Windows.Forms;
using NetromMessageBoard.Controller;
using NetromMessageBoard.Interfaces;
using NetromMessageBoard.Model;
using NetromMessageBoard.Repository;
using NetromMessageBoard.Repository.Interfaces;

namespace NetromMessageBoard
{
    public partial class RegisterForm : Form, IRegisterController
    {
        private const string TheRegisterFailed = "The register failed.";
        private const string Caption = "Error";
        private RegisterController _register;

        public RegisterForm()
        {
            InitializeComponent();

            _register = new RegisterController(this);

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

            if (!_register.ValidateFieldsNotEmpty())
            {
                lblAllFieldsAreMandatory.Show();
            }
            else if (!_register.ValidateUsername())
            {
                lblUserNameAlreadyExists.Show();
            }
            else if (!_register.ValidatePassword())
            {
                lblPasswordMismatch.Show();
            }
            else if (!_register.RegisterNewUser())
            {
                MessageBox.Show(TheRegisterFailed, Caption, MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(@"The user " + UserName + @" was successfully created!",@"Successful registration");
                Hide();
                new LoginForm().Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompany.SelectedValue != null)
            {
                var departmentRepository = UnitOfWork.Instance.GetRepository<IDepartmentRepository>();
                cmbDepartment.DataSource = departmentRepository.GetAllDepartments()
                    .Where(d => d.CompanyID == ((Company) cmbCompany.SelectedValue).ID).ToList();
                cmbDepartment.DisplayMember = "Name";
                cmbDepartment.SelectedIndex = -1;
            }

        }

        public string FirstName
        {
            get { return txtFirstName.Text; }
            set { txtFirstName.Text = value; }
        }

        public string LastName
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }

        public string UserName
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public string RepeatPassword
        {
            get { return txtRepeatPassword.Text; }
            set { txtRepeatPassword.Text = value; }
        }

        public string Company
        {
            get { return cmbCompany.Text; }
            set { cmbCompany.Text = value; }
        }

        public string Department
        {
            get { return cmbDepartment.Text; }
            set { cmbDepartment.Text = value; }
        }

        public DateTime BirthDate
        {
            get { return dateTimePickerBirthDate.Value.Date; }
            set { dateTimePickerBirthDate.Value = value; }
        }
    }
}