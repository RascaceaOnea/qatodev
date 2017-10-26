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
    public partial class MainForm : Form
    {
        protected QaToDevEntities Context { get; private set; }

        public MainForm()
        {
            InitializeComponent();

            Context = new QaToDevEntities();
            PopulateUsersGrid();
        }
        


        private void PopulateUsersGrid()
        {
            dtaGridUsers.Rows.Clear();
            List<User> users = Context.Users.ToList();
            foreach (User user in users)
            {
                this.dtaGridUsers.Rows.Add(
                    user.ID,
                    user.UserName,
                    user.LastName + " " + user.FirstName,
                    user.Company.Name,
                    user.Department.Name,
                    user.BirthDate.Value.ToString("yyyy-MM-dd"),
                    user.ArrivalDate.ToString("yyyy-MM-dd"));
            }
        }

        private void dtaGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                try
                {
                    int userID = (int)dtaGridUsers[0, e.RowIndex].Value;

                    var user = Context.Users.First(u => u.ID == userID);

                    Context.Users.Remove(user);

                    Context.SaveChanges();
                }
                catch { Exception ex; }
            }
            
            PopulateUsersGrid();
        }
    }
}
