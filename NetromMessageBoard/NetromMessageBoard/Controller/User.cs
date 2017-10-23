using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetromMessageBoard.Controller
{
    class User
    {
        internal static bool Login(string UserName, string Password)
        {
            if (UserName == "" || Password == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return false;
            }
            //try
            //{
            //Create SqlConnection
            string connectionString = "Server=.\\SQLExpress;Database=NetromMessageBoard;User Id=sa;Password=sa; ";


            SqlConnection connection = new SqlConnection(connectionString);
            
            SqlCommand cmd = new SqlCommand("Select * from tbl_User where UserName=@username and Password=@password", connection);
                cmd.Parameters.AddWithValue("@username", UserName);
                cmd.Parameters.AddWithValue("@password", Password);
                connection.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                connection.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return false;
            //}
        }
    }
}
