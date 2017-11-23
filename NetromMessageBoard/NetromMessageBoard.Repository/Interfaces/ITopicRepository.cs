using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetromMessageBoard.Model;

namespace NetromMessageBoard.Repository.Interfaces
{
    public interface ITopicRepository : IBaseRepository
    {
        Topic GetTopicById(int id);
        IQueryable<Topic> GetAllTopics();
    }
}
