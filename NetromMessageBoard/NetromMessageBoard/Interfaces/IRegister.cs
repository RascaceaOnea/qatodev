using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetromMessageBoard.Interfaces
{
    interface IRegisterController
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string RepeatPassword { get; set; }
        string Company { get; set; }
        string Department { get; set; }
        DateTime BirthDate { get; set; }
    }
}