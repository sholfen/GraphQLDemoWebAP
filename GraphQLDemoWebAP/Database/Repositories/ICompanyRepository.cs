using GraphQLDemoWebAP.Database.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemoWebAP.Database.Repositories
{
    public interface ICompanyRepository
    {
        List<Company> GetAll();
        List<Company> GetSomeColumnsOfAll(List<string> columns);
        Company GetItemById(int id);
        Company UpdateCompany(Company company);
    }
}
