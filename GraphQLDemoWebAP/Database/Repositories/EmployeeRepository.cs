using GraphQLDemoWebAP.Database.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace GraphQLDemoWebAP.Database.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository()
        {

        }

        public override List<Employee> GetAll()
        {
            return DataPool.Employees;
        }

        public override Employee GetItemById(int id)
        {
            return DataPool.Employees.Find(n => n.Id == id);
        }

        public override List<Employee> GetSomeColumnsOfAll(List<string> columns)
        {
            List<Employee> results = new List<Employee>();
            List<Employee> allDatas = DataPool.Employees;
            List<PropertyInfo> properties = typeof(Employee).GetProperties().ToList();

            foreach (Employee item in allDatas)
            {
                Employee employee = new Employee();
                foreach (PropertyInfo propertyInfo in properties)
                {
                    if (columns.Contains(propertyInfo.Name))
                    {
                        propertyInfo.SetValue(employee, propertyInfo.GetValue(item));
                    }             
                }
                results.Add(employee);
            }

            return results;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            Employee data = GetItemById(employee.Id);
            data.Name = employee.Name;
            data.Age = employee.Age;
            return data;
        }
    }
}
