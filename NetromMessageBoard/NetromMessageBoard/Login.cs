using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetromMessageBoard.Controller
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string UserName = txt_UserName.Text;
            string Password = txt_Password.Text;
            if (Controller.User.Login(UserName, Password))
            {
                 MessageBox.Show("Login Successful!");
                 this.Hide();
                Form fm = new Form();
                fm.Show();
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
