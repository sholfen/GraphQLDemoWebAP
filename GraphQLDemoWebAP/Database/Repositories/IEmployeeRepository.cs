using GraphQLDemoWebAP.Database.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemoWebAP.Database.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
        List<Employee> GetSomeColumnsOfAll(List<string> columns);
        Employee GetItemById(int id);
        Employee UpdateEmployee(Employee employee);
    }
}
