using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetromMessageBoard.Interfaces;
using NetromMessageBoard.Repository;
using NetromMessageBoard.Repository.Interfaces;

namespace NetromMessageBoard.Controller
{
    class RegisterController
    {
        private readonly IRegister _register;

        public RegisterController(IRegister register)
        {
            _register = register;
        }

        public bool ValidateFieldsNotEmpty()
        {
            return (!string.IsNullOrEmpty(_register.FirstName)
                    && !string.IsNullOrEmpty(_register.LastName)
                    && !string.IsNullOrEmpty(_register.UserName)
                    && !string.IsNullOrEmpty(_register.Password)
                    && !string.IsNullOrEmpty(_register.RepeatPassword)
                    && !string.IsNullOrEmpty(_register.Company)
                    && !string.IsNullOrEmpty(_register.Department));
        }

        public bool ValidatePassword()
        {
            return _register.Password == _register.RepeatPassword;
        }

        public bool ValidateUsername()
        {
            var userRepository = UnitOfWork.Instance.GetRepository<IUserRepository>();
            return userRepository.IsUsernameUnique(_register.UserName);
        }

        public bool RegisterNewUser()
        {
            var userRepository = UnitOfWork.Instance.GetRepository<IUserRepository>();
            
            return userRepository.AddNewUser(_register.FirstName, _register.LastName, _register.BirthDate, _register.UserName,
                _register.Password, _register.Company, _register.Department);
        }
    }
}
