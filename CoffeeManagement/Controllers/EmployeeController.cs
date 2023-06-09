﻿using CoffeeManagement.Models.Employees;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        private IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger _logger;

        public EmployeeController(IEmployeeRepository employeeRepository, ILogger<EmployeeController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _employeeRepository = employeeRepository;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_employeeRepository.GetAllEmployees());
        }
        [HttpGet]
        public IActionResult Details(int ID)
        {
            Employee employee = _employeeRepository.GetEmployee(ID);
            ViewData["PageTittle"] = "Employee Details";
            return View(employee); 
        }

        // Phương thức trả về danh sách các nhân viên
        public IActionResult List()
        {
            // return a view with IEnumerable<Employee>
            ViewBag.PageTitle = "Employee List";
            return View(_employeeRepository.GetAllEmployees());
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeRepository.Add(employee);
            return View("List", _employeeRepository.GetAllEmployees());
        }

        [HttpGet]
        public IActionResult UpdateEmployee(int ID)
        {
            _logger.LogInformation("Update Employee ID");
            return View("UpdateEmployee", _employeeRepository.GetEmployee(ID));
        }

        [HttpPost]
        public IActionResult UpdateEmployee(Employee employee)
        {
            _logger.LogInformation("Update Employee");
            _employeeRepository.Update(employee);
            return View("List", _employeeRepository.GetAllEmployees());
        }

        //[HttpPost]
        public IActionResult DeleteEmployee(int ID)
        {
            _logger.LogInformation("Delete Employee");
            _employeeRepository.Delete(_employeeRepository.GetEmployee(ID));
            return View("List", _employeeRepository.GetAllEmployees());
        }
    }
}
