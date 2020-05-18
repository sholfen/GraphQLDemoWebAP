using GraphQL.Types;
using GraphQLDemoWebAP.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemoWebAP.GraphQLlib.Types
{
    public class AllDatas : ObjectGraphType
    {
        public AllDatas(IEmployeeRepository employeeRepository, ICompanyRepository companyRepository)
        {
            Name = "AllDatas";
            Field<ListGraphType<EmployeeType>>(
                "employees",
                resolve: context => employeeRepository.GetSomeColumnsOfAll(new List<string> { "Name", "Age" })
            );
            Field<ListGraphType<CompanyType>>(
                "companies",
                resolve: context =>
                {
                    var names = context.SubFields.Keys.ToList();
                    return companyRepository.GetSomeColumnsOfAll(names);
                }
            );
        }
    }
}
