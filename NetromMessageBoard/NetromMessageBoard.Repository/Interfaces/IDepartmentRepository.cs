using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetromMessageBoard.Model;

namespace NetromMessageBoard.Repository.Interfaces
{
    public interface IDepartmentRepository
    {
        Department GetDepartmentById();
        Department AddNewDepartment(Department departmentToAdd);
        Department DeleteDepartmentById(int id);
    }
}
