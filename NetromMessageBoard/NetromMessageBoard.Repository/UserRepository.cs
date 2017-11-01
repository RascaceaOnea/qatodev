using NetromMessageBoard.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using NetromMessageBoard.Model;

namespace NetromMessageBoard.Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public IQueryable<User> GetAllUsers()
        {
            return Context.Users.AsQueryable();
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
            return false;
        }

        public bool AddNewUser(string firstName, string lastName, DateTime birthDate, string userName, string password, Company company, Department department)
        {
            try
            {
                byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                string hash = System.Text.Encoding.ASCII.GetString(data);

                User userToBeAdded = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = birthDate.Date,
                    ArrivalDate = DateTime.Now.Date,
                    UserName = userName,
                    UserPassword = hash,
                    CompanyID = company.ID,
                    DepartmentID = department.ID
                };

                Context.Users.Add(userToBeAdded);
                SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }

        public bool CheckCredentials(string userName, string password)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);

            var users = GetAllUsers();

            return users.Any(u => u.UserName == userName && u.UserPassword == hash);
        }
    }
}
