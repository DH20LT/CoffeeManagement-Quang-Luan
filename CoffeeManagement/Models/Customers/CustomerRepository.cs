using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace CoffeeManagement.Models.Customers
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;

        private readonly ILogger _logger;
        public CustomerRepository(AppDbContext context, ILogger<CustomerRepository> logger)
        {
            _logger = logger;
            _context = context;
        }

        public Customer GetCustomer(int ID)
        {
            // Tạo các nhân viên
            _logger.LogInformation("Get Customer");
            return _context.Customers.Find(ID);
        }


        public IEnumerable<Customer> GetAllCustomers()
        {
            _logger.LogInformation("Get All Customers");
            return _context.Customers;
        }

        public Customer Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public Customer Update(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return customer;
        }

        public Customer Delete(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return customer;
        }
    }
}
