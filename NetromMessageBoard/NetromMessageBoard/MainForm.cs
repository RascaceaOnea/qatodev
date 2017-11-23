﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetromMessageBoard.Model;
using NetromMessageBoard.Repository;
using NetromMessageBoard.Repository.Interfaces;

namespace NetromMessageBoard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PopulateUsersGrid();
        }

        private void PopulateUsersGrid()
        {
            dtaGridUsers.Rows.Clear();
            var userRepository = UnitOfWork.Instance.GetRepository<IUserRepository>();
            var users = userRepository.GetAllUsers();
            foreach (User user in users)
            {
                if (user.BirthDate != null)
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
                    int userId = (int)dtaGridUsers[0, e.RowIndex].Value;
                    var userRepository = UnitOfWork.Instance.GetRepository<IUserRepository>();
                    userRepository.DeleteUserById(userId);
                }
                catch
                {
                }
            }
            
            PopulateUsersGrid();
        }

        private void topicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TopicForm().Show();
        }
    }
}
