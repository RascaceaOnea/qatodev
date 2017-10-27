using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetromMessageBoard.Repository.Interfaces;

namespace NetromMessageBoard.Repository
{
    class DepartmentRepository : BaseRepository, IDepartmentRepository
    {
        public Department AddNewDepartment(Department departmentToAdd)
        {
            throw new NotImplementedException();
        }

        public Department DeleteDepartmentByID(int id)
        {
            throw new NotImplementedException();
        }

        public Department GetDepartmentByID()
        {
            throw new NotImplementedException();
        }
    }
}
