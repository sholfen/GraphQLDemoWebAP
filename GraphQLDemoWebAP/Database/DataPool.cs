using GraphQLDemoWebAP.Database.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemoWebAP.Database
{
    public static class DataPool
    {
        public static List<Employee> Employees { get; set; }
        public static List<Company> Companies { get; set; }

        static DataPool()
        {
            Employees = new List<Employee>
            {
                new Employee{ Id = 1, Name = "Peter", Age = 36, CompanyId = 1 },
                new Employee{ Id = 2, Name = "John", Age = 24, CompanyId = 1}
            };

            Companies = new List<Company>
            {
                new Company{ Id = 1, Name = "TreandMicro", Desc = "Anti-Virus Company"},
                new Company{ Id = 2, Name = "Synology", Desc = "NAS Company"}
            };
        }
    }
}
