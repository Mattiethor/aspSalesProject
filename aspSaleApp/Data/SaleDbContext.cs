using Microsoft.EntityFrameworkCore;
using ntv_database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntv_database.Migrations
{
    public class SaleDbContext : DbContext
    {
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ItemOrder> ItemsOrders { get; set; }

 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SaleDb");
        }

    }
}


