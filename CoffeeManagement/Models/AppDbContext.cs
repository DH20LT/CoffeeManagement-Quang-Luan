using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using CoffeeManagement.Models.Employees;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using CoffeeManagement.Models.Customers;
using CoffeeManagement.Models.Orders;

namespace CoffeeManagement.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Make add Migration work
            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(x => new { x.UserId });
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(x => new { x.RoleId });
            modelBuilder.Entity<IdentityUserToken<string>>().HasKey(x => new { x.UserId, x.Value });
            // Make add Migration work

        }

        public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
        {
            public AppDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

                optionsBuilder.UseSqlite(
                    "Data Source=" +
                           Path.Combine(Directory.GetCurrentDirectory(), "mydb.db")
                );

                return new AppDbContext(optionsBuilder.Options);
            }
        }
    }
}
