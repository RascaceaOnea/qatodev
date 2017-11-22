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
using NetromMessageBoard.Repository;
using NetromMessageBoard.Repository.Interfaces;

namespace NetromMessageBoard
{
    public partial class TopicForm : Form
        
    {
        private const string CurrentUserTxt = "User: ";

        public TopicForm()
        {
            InitializeComponent();
            PopulateListView();
            txtCurrentUser.Text = CurrentUserTxt + HelperClass.currentUser;
        }

        private void PopulateListView()
        {
            //listViewTopics.Clear();
            var topicRepository = UnitOfWork.Instance.GetRepository<TopicRepository>();
            var userRepository = UnitOfWork.Instance.GetRepository<UserRepository>();
            var allTopics = topicRepository.GetAllTopics();
            foreach (var topic in allTopics)
            {
                //ListViewItem lvi = new ListViewItem();
                //lvi.SubItems.Add(topic.ID.ToString());
                //lvi.SubItems.Add(topic.Name);
                //lvi.SubItems.Add(topic.Description);
                //lvi.SubItems.Add(userRepository.GetUserById(topic.UserID).LastName + userRepository.GetUserById(topic.UserID).FirstName);

                string[] row = { topic.ID.ToString(), topic.Name, topic.Description, userRepository.GetUserById(topic.UserID).LastName + " " + userRepository.GetUserById(topic.UserID).FirstName };
                var listViewItem = new ListViewItem(row);

                listViewTopics.Items.Add(listViewItem);
            }
        }

        private void listViewTopics_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
