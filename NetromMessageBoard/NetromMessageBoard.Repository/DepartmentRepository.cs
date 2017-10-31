using System;
using System.Collections.Generic;
using System.Linq;
using NetromMessageBoard.Model;
using NetromMessageBoard.Repository.Interfaces;

namespace NetromMessageBoard.Repository
{
    public class DepartmentRepository : BaseRepository, IDepartmentRepository
    {
        public bool AddNewDepartment(Department departmentToAdd)
        {
            try
            {
                Context.Departments.Add(departmentToAdd);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool DeleteDepartmentById(int id)
        {

            Department departmentToDelete = Context.Departments.First(d => d.ID == id);
            if (departmentToDelete != null)
            {
                Context.Departments.Remove(departmentToDelete);
                SaveChanges();
                return true;
            }
            return false;
        }

        public List<Department> GetAllDepartments()
        {
            return Context.Departments.ToList();
        }

        public Department GetDepartmentById(int id)
        {
            return Context.Departments.FirstOrDefault(d => d.ID == id);
        }
    }
}
