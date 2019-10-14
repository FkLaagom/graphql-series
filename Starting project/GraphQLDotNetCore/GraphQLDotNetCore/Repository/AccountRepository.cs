using System;
using System.Collections.Generic;
using System.Linq;
using GraphQLDotNetCore.Contracts;
using GraphQLDotNetCore.Entities;

namespace GraphQLDotNetCore.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationContext _context;

        public AccountRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Account> GetAll() => _context.Accounts.ToList();

        public IEnumerable<Account> GetAllAccountsPerOwner(Guid ownerId) => _context.Accounts.Where(x => x.OwnerId == ownerId).ToList();
    }
}
