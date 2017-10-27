using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetromMessageBoard.Model;

namespace NetromMessageBoard.Repository.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        bool DeleteUserById(int id);
        bool AddNewUser(User userToBeAdded);
    }
    
}
