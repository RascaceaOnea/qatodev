using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetromMessageBoard.Model;
using NetromMessageBoard.Repository.Interfaces;

namespace NetromMessageBoard.Repository
{
    class DepartmentRepository : BaseRepository, IDepartmentRepository
    {
        public Department AddNewDepartment(Department departmentToAdd)
        {
            throw new NotImplementedException();
        }

        public Department DeleteDepartmentById(int id)
        {
            throw new NotImplementedException();
        }

        public Department GetDepartmentById()
        {
            throw new NotImplementedException();
        }
    }
}
