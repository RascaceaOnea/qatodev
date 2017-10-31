using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetromMessageBoard.Model;

namespace NetromMessageBoard.Repository.Interfaces
{
    public interface ICompanyRepository
    {
        Company GetCompanyById(int id);
        bool AddNewCompany(Company companyToAdd);
        bool DeleteCompanyById(int id);
        List<Company> GetAllCompanies();
    }
}
