﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetromMessageBoard.Repository.Interfaces
{
    public interface IDepartmentRepository
    {
        Department GetDepartmentByID();
        Department AddNewDepartment(Department departmentToAdd);
        Department DeleteDepartmentByID(int id);
    }
}
