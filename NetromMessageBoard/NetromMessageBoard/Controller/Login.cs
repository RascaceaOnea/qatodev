using NetromMessageBoard.Repository;
using System;
using System.Runtime.Remoting.Contexts;
using NetromMessageBoard.Model;
using System.Linq;
using System.Windows.Forms;

namespace NetromMessageBoard.Controller
{
    internal class Login
    {
        internal static bool CheckCredentials(string userName, string password)
        {
            if ((userName == "") || (password == ""))
            {
                MessageBox.Show("Please provide UserName and Password");
            }

            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);

            var users = new UserRepository().GetAllUsers();

            if (users.FirstOrDefault(u => u.UserName == userName && u.UserPassword == hash) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}