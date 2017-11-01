using System;
using System.Windows.Forms;
using NetromMessageBoard.Controller;
using NetromMessageBoard.Repository;
using NetromMessageBoard.Repository.Interfaces;

namespace NetromMessageBoard
{
    public partial class LoginForm : Form, ILogin
    {
        private const string PleaseProvideUsernameAndPassword = "Please provide UserName and Password";
        private LoginController _controller;

        public LoginForm()
        {
            InitializeComponent();
            _controller = new LoginController(this);

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterForm().Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!_controller.Validate())
            {
                MessageBox.Show(PleaseProvideUsernameAndPassword);
            }
            else
            {
                if (_controller.CheckCredentials())
                {
                    //_controller.Navigate(Mainform)???
                    Hide();
                    new MainForm().Show();
                }
                else
                {
                    lblError.Show();
                }
            }


        }

        public string User
        {
            get { return txt_UserName.Text; }
            set { txt_UserName.Text = value; }
        }
        public string Password
        {
            get { return txt_Password.Text; }
            set { txt_Password.Text = value; }
        }
    }

    public interface ILogin
    {
        string User { get; set; }
        string Password { get; set; }
    }

    public class LoginController
    {
        private readonly ILogin _login;

        public LoginController(ILogin login)
        {
            _login = login;
        }

        public bool Validate()
        {
            return !string.IsNullOrEmpty(_login.User) && !string.IsNullOrEmpty(_login.Password);
        }

        public bool CheckCredentials()
        {
            var userRepository = UnitOfWork.Instance.GetRepository<IUserRepository>();
            return (userRepository.CheckCredentials(_login.User, _login.Password));
        }
    }

}
