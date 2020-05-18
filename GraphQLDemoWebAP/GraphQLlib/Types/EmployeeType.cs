using GraphQL.Types;
using GraphQLDemoWebAP.Database.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemoWebAP.GraphQLlib.Types
{
    public class EmployeeType : ObjectGraphType<Employee>
    {
        public EmployeeType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("...");
            Field(x => x.Name).Description("...");
            Field(x => x.Age, type: typeof(IntGraphType)).Description("...");
            Field(x => x.CompanyId, type: typeof(IntGraphType)).Description("...");
        }
    }
}
