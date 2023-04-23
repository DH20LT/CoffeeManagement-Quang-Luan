using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using CoffeeManagement.Models.Employees;
using CoffeeManagement.Models.ViewModals;
using CoffeeManagement.Models.Customers;
using CoffeeManagement.Models.Orders;

namespace CoffeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IEmployeeRepository _employeeRepository;
        private ICustomerRepository _customerRepository;
        private IOrderRepository _orderRepository;

        private IWebHostEnvironment _webHost;

        public HomeController(ILogger<HomeController> logger,
            IWebHostEnvironment webHost, IEmployeeRepository employeeRepository,
            ICustomerRepository customerRepository, IOrderRepository orderRepository)
        {
            _logger = logger;
            _webHost = webHost;
            _employeeRepository = employeeRepository;
            _customerRepository = customerRepository;
            _orderRepository = orderRepository;
        }
    }
}
