using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetromMessageBoard.Interfaces
{
    public interface ILogin
    {
        string User { get; set; }
        string Password { get; set; }
    }
}
