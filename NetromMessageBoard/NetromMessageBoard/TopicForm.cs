using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetromMessageBoard.Repository;
using NetromMessageBoard.Repository.Interfaces;

namespace NetromMessageBoard
{
    public partial class TopicForm : Form
    {
        public TopicForm()
        {
            InitializeComponent();
            PopulateListView();
        }

        private void PopulateListView()
        {
            listViewTopics.Clear();
            var topicRepository = UnitOfWork.Instance.GetRepository<ITopicRepository>();
            var userRepository = UnitOfWork.Instance.GetRepository<IUserRepository>();
            var allTopics = topicRepository.GetAllTopics();
            foreach (var topic in allTopics)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(topic.ID.ToString());
                lvi.SubItems.Add(topic.Name);
                lvi.SubItems.Add(topic.Description);
                lvi.SubItems.Add(userRepository.GetUserById(topic.UserID).LastName + userRepository.GetUserById(topic.UserID).FirstName);

                listViewTopics.Items.Add(lvi);
            }
        }

        private void listViewTopics_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
