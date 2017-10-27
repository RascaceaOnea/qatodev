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

namespace NetromMessageBoard.Controller
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterForm().Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (Login.CheckCredentials(txt_UserName.Text, txt_Password.Text))
            {
                Hide();
                new MainForm().Show();
            }
            else
            {
                lblError.Show();
            }
        }
    }

}
