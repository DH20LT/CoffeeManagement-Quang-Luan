using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace CoffeeManagement.Models.Employees
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        private readonly ILogger _logger;
        public EmployeeRepository(AppDbContext context, ILogger<EmployeeRepository> logger)
        {
            _logger = logger;
            _context = context;
        }

        public Employee GetEmployee(int ID)
        {
            // Tạo các nhân viên
            _logger.LogInformation("Get Employee");
            return _context.Employees.Find(ID);
        }


        public IEnumerable<Employee> GetAllEmployees()
        {
            _logger.LogInformation("Get All Employees");
            return _context.Employees;
        }

        public Employee Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee Update(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee Delete(Employee employee)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return employee;
        }
    }
}
