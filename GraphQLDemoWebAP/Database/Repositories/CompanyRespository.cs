using GraphQLDemoWebAP.Database.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace GraphQLDemoWebAP.Database.Repositories
{
    public class CompanyRespository : BaseRepository<Company>, ICompanyRepository
    {
        public override List<Company> GetAll()
        {
            return DataPool.Companies;
        }

        public override Company GetItemById(int id)
        {
            return DataPool.Companies.Find(n => n.Id == id);
        }

        public override List<Company> GetSomeColumnsOfAll(List<string> columns)
        {
            List<Company> results = new List<Company>();
            List<Company> allDatas = DataPool.Companies;
            List<PropertyInfo> properties = typeof(Company).GetProperties().ToList();

            foreach (Company item in allDatas)
            {
                Company company = new Company();
                foreach (PropertyInfo propertyInfo in properties)
                {
                    propertyInfo.SetValue(company, propertyInfo.GetValue(item));        
                }
                results.Add(company);
            }

            return results;
        }

        public Company UpdateCompany(Company company)
        {
            Company data = GetItemById(company.Id);
            data.Name = company.Name;
            data.Desc = company.Desc;
            return data;
        }
    }
}
