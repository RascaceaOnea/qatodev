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

        public bool AddNewUser(string firstName, string lastName, DateTime birthDate, string userName, string password, string company, string department)
        {
            try
            {
                byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                string hash = System.Text.Encoding.ASCII.GetString(data);

                int companyId = (Context.Companies.FirstOrDefault(c => c.Name == company).ID);
                int departmentId = Context.Departments.FirstOrDefault(d => d.Name == department).ID;

                User userToBeAdded = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = birthDate.Date,
                    ArrivalDate = DateTime.Now.Date,
                    UserName = userName,
                    UserPassword = hash,
                    CompanyID = companyId,
                    DepartmentID = departmentId
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

        public bool IsUsernameUnique(string userName)
        {
            var users = GetAllUsers();

            return !users.Any(u => u.UserName == userName);
        }

        public User GetUserById(int id)
        {
            var users = GetAllUsers();
            return users.FirstOrDefault(u => u.ID == id);
        }
    }
}
