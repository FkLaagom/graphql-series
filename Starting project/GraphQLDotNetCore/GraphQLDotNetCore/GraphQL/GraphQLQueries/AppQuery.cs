using GraphQL.Types;
using GraphQLDotNetCore.Contracts;
using GraphQLDotNetCore.GraphQL.GraphQLSchema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotNetCore.GraphQL.GraphQLQueries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IOwnerRepository repository, IAccountRepository accounts)
        {
            Field<ListGraphType<OwnerType>>(
                "owners",
                resolve: context => repository.GetAll()
            );

            Field<ListGraphType<AccountType>>(
                "accounts",
                resolve: context => accounts.GetAll()
                );
        }
    }
}
