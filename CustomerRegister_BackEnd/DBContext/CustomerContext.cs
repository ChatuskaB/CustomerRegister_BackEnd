using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using CustomerRegister_BackEnd.Models;
using System.Collections.Generic;


namespace CustomerRegister_BackEnd.DBContext
{
    public class CustomerContext : DbContext
    {

        public CustomerContext(DbContextOptions<CustomerContext> options)
        : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; } = null!;
    }
}




