using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using CoffeeManagement.Models.Employees;
using CoffeeManagement.Models.ViewModals;

namespace CoffeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IEmployeeRepository _employeeRepository;

        private IWebHostEnvironment _webHost;

        public HomeController(ILogger<HomeController> logger,
            IWebHostEnvironment webHost, IEmployeeRepository employeeRepository)
        {
            _logger = logger;
            _webHost = webHost;
            _employeeRepository = employeeRepository;
        }
    }
}
