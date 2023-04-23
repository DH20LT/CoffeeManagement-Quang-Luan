using CoffeeManagement.Models.Customers;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeManagement.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerRepository _customerRepository;
        private IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger _logger;

        public CustomerController(ICustomerRepository customerRepository, ILogger<CustomerController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _customerRepository = customerRepository;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_customerRepository.GetAllCustomers());
        }
        [HttpGet]
        public IActionResult Details(int ID)
        {
            Customer customer = _customerRepository.GetCustomer(ID);
            ViewData["PageTittle"] = "Customer Details";
            return View(customer);
        }

        // Phương thức trả về danh sách các khách hàng
        public IActionResult List()
        {
            // return a view with IEnumerable<Customer>
            ViewBag.PageTitle = "Customer List";
            return View(_customerRepository.GetAllCustomers());
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _customerRepository.Add(customer);
            return View("List", _customerRepository.GetAllCustomers());
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int ID)
        {
            _logger.LogInformation("Update Customer ID");
            return View("UpdateCustomer", _customerRepository.GetCustomer(ID));
        }

        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _logger.LogInformation("Update Customer");
            _customerRepository.Update(customer);
            return View("List", _customerRepository.GetAllCustomers());
        }
        //[HttpPost]
        public IActionResult DeleteCustomer(int ID)
        {
            _logger.LogInformation("Delete Customer");
            _customerRepository.Delete(_customerRepository.GetCustomer(ID));
            return View("List", _customerRepository.GetAllCustomers());
        }
    }
}
