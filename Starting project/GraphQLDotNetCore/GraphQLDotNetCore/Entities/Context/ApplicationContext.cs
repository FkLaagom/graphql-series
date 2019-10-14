using GraphQLDotNetCore.Entities.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotNetCore.Entities
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
            :base(options)
        {
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlServer(@"Data Source=DESKTOP-SE1DVRQ\SQLEXPRESS;Initial Catalog=GQL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=FalseData Source=DESKTOP-SE1DVRQ\SQLEXPRESS;Initial Catalog=GQL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var ids = new Guid[] { Guid.NewGuid(), Guid.NewGuid() };

            modelBuilder.ApplyConfiguration(new OwnerContextConfiguration(ids));
            modelBuilder.ApplyConfiguration(new AccountContextConfiguration(ids));
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
