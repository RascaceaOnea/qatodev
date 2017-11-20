using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetromMessageBoard.Model;
using NetromMessageBoard.Repository.Interfaces;

namespace NetromMessageBoard.Repository
{
    class TopicRepository : BaseRepository, ITopicRepository
    {
        public IQueryable<Topic> GetAllTopics()
        {
            return Context.Topics.AsQueryable();
        }

        public Topic GetTopicById(int id)
        {
            return Context.Topics.FirstOrDefault(t=>t.ID == id);
        }
    }
}
