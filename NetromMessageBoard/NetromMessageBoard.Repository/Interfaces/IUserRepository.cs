using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetromMessageBoard.Model;

namespace NetromMessageBoard.Repository.Interfaces
{
    public interface IUserRepository : IBaseRepository
    {
        IQueryable<User> GetAllUsers();
        bool DeleteUserById(int id);
        bool AddNewUser(string firstName, string lastName, DateTime birthDate, string userName, string password,
            string company, string department);
        bool CheckCredentials(string userName, string password);
        bool IsUsernameUnique(string userName);
        User GetUserById(int id);
    }
    
}
