using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetromMessageBoard.Interfaces;
using NetromMessageBoard.Repository;
using NetromMessageBoard.Repository.Interfaces;

namespace NetromMessageBoard.Controller
{
    public class LoginController
    {
        private readonly ILogin _login;

        public LoginController(ILogin login)
        {
            _login = login;
        }

        public bool Validate()
        {
            return !string.IsNullOrEmpty(_login.User) && !string.IsNullOrEmpty(_login.Password);
        }

        public bool CheckCredentials()
        {
            var userRepository = UnitOfWork.Instance.GetRepository<IUserRepository>();
            return (userRepository.CheckCredentials(_login.User, _login.Password));
        }
    }
}
