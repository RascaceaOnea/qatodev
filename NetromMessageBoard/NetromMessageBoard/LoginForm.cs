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
            if ((txt_UserName.Text == "") || (txt_Password.Text == ""))
            {
                MessageBox.Show("Please provide UserName and Password");
            }

            using (QaToDevEntities context = new QaToDevEntities())
            {
                byte[] data = System.Text.Encoding.ASCII.GetBytes(txt_Password.Text);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                String hash = System.Text.Encoding.ASCII.GetString(data);

                User user = context.Users.FirstOrDefault(u => u.UserName == txt_UserName.Text && u.UserPassword == hash);
                
                if (user != null)
                {
                    this.Hide();
                    new MainForm().Show();
                }
                else
                {
                    lblError.Show();
                }
            }
        }
          
    }
}
