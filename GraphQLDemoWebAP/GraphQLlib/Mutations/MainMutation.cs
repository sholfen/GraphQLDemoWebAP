using GraphQL;
using GraphQL.Types;
using GraphQLDemoWebAP.Database.DataModels;
using GraphQLDemoWebAP.Database.Repositories;
using GraphQLDemoWebAP.GraphQLlib.Types;

namespace GraphQLDemoWebAP.GraphQLlib.Mutations
{
    public class MainMutation : ObjectGraphType
    {
        public MainMutation(IEmployeeRepository employeeRepository, ICompanyRepository companyRepository)
        {
            Name = "Mutation";

            Field<EmployeeType>(
                "updateEmployee",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" },
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "age" },
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "name" }
                ),
                resolve: context =>
                {
                    int id = context.GetArgument<int>("id");
                    int age = context.GetArgument<int>("age");
                    string name = context.GetArgument<string>("name");
                    Employee employee = new Employee { Id = id, Age = age, Name = name };
                    employee = employeeRepository.UpdateEmployee(employee);
                    return employee;
                });

            Field<CompanyType>(
                "updateCompany",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<CompanyInputType>> { Name = "company" }
                ),
                resolve: context =>
                {
                    Company data = context.GetArgument<Company>("company");
                    Company company = new Company
                    {
                        Id = data.Id,
                        Name = data.Name,
                        Desc = data.Desc
                    };
                    company = companyRepository.UpdateCompany(company);
                    return company;
                });
        }
    }
}
