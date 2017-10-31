using System;
using System.Collections.Generic;
using System.Linq;
using NetromMessageBoard.Model;
using NetromMessageBoard.Repository.Interfaces;

namespace NetromMessageBoard.Repository
{
    public class CompanyRepository : BaseRepository, ICompanyRepository
    {
        public bool AddNewCompany(Company companyToAdd)
        {
            try
            {
                Context.Companies.Add(companyToAdd);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }

        public bool DeleteCompanyById(int id)
        {
            Company companyToDelete = Context.Companies.First(c => c.ID == id);
            if (companyToDelete != null)
            {
                Context.Companies.Remove(companyToDelete);
                SaveChanges();
                return true;
            }
            return false;
        }

        public List<Company> GetAllCompanies()
        {
            return Context.Companies.ToList();
        }

        public Company GetCompanyById(int id)
        {
            return Context.Companies.FirstOrDefault(c => c.ID == id);
        }
    }
}
