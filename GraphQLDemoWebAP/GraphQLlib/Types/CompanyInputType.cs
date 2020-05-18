using GraphQL.Types;
using GraphQLDemoWebAP.Database.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemoWebAP.GraphQLlib.Types
{
    public class CompanyInputType: InputObjectGraphType<Company>
    {
        public CompanyInputType()
        {
            Name = "CompanyInput";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("...");
            Field(x => x.Name).Description("...");
            Field(x => x.Desc).Description("...");
        }
    }
}
