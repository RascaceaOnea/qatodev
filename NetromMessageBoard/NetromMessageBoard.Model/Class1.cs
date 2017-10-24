using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetromMessageBoard.Model
{
    [Flags]
    public enum Rights
    {
        Normal = 0,
        Admin = 1,
        CompanyAdmin = 2,

    }
}
