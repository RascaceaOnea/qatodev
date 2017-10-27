using NetromMessageBoard.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetromMessageBoard.Model;

namespace NetromMessageBoard.Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public List<User> GetAllUsers()
        {
            return Context.Users.ToList();
        }

        public bool DeleteUserById(int id)
        {
            User userToDelete = Context.Users.First(u => u.ID == id);
            if (userToDelete != null)
            {
                Context.Users.Remove(userToDelete);
                SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
    }
}
