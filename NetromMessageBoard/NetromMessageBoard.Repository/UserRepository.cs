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

        public bool AddNewUser(string firstName, string lastName, DateTime birthDate, string userName, string password, Company company, Department department)
        {
            User userToBeAdded = new User();

            userToBeAdded.FirstName = firstName;
            userToBeAdded.LastName = lastName;
            userToBeAdded.BirthDate = birthDate.Date;
            userToBeAdded.ArrivalDate = DateTime.Now.Date;
            userToBeAdded.UserName = userName;

            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);

            userToBeAdded.UserPassword = hash;
            userToBeAdded.CompanyID = company.ID;
            userToBeAdded.DepartmentID = department.ID;
            
            Context.Users.Add(userToBeAdded);
            SaveChanges();

            return true;
        }
    }
}
