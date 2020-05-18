using GraphQL;
using GraphQL.Types;
using GraphQLDemoWebAP.GraphQLlib.Mutations;
using GraphQLDemoWebAP.GraphQLlib.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemoWebAP.GraphQLlib.Schemas
{
    public class MainSchema : Schema
    {
        public MainSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<MainQuery>();
            Mutation = resolver.Resolve<MainMutation>();
        }

    }
}
