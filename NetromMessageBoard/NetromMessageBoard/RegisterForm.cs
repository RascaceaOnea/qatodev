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
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (QaToDevEntities context = new QaToDevEntities())
            {
                if (txtFirstName == null)
                {
                    lblMandatoryFields.
                }

                User user = context.Users.FirstOrDefault(u => u.UserName == txtUserName.Text);

                if (user != null)
                {
                    lblUserNameAlreadyExists.Show();
                }
                else
                {
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
