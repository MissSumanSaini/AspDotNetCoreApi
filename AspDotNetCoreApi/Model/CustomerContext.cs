using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreApi.Model
{
    public class CustomerContext :DbContext
    {

        public CustomerContext()
        {
        }

        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Customer> customers { get; set; }

      
    }

}
