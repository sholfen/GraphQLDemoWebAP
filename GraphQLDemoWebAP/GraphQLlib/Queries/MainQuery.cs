using GraphQL.Types;
using GraphQLDemoWebAP.Database.DataModels;
using GraphQLDemoWebAP.Database.Repositories;
using GraphQLDemoWebAP.GraphQLlib.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemoWebAP.GraphQLlib.Queries
{
    public class MainQuery: ObjectGraphType
    {
        public MainQuery()
        {
            Name = "Query";
            Field<AllDatas>(
                "AllDatas",
                resolve: context => new {}
            );
        }
    }
}
