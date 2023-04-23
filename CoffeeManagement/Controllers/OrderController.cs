using CoffeeManagement.Models.Orders;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeManagement.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository _orderRepository;
        private IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger _logger;

        public OrderController(IOrderRepository orderRepository, ILogger<CustomerController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _orderRepository = orderRepository;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_orderRepository.GetAllOrderLists());
        }
        [HttpGet]
        public IActionResult Details(int ID)
        {
            Order order = _orderRepository.GetOrderList(ID);
            ViewData["PageTittle"] = "Customer Details";
            return View(order);
        }

        // Phương thức trả về danh sách các khách hàng
        public IActionResult List()
        {
            // return a view with IEnumerable<Customer>
            ViewBag.PageTitle = "Customer List";
            return View(_orderRepository.GetAllOrderLists());
        }

        [HttpGet]
        public IActionResult AddOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            _orderRepository.Add(order);
            return View("List", _orderRepository.GetAllOrderLists());
        }

        [HttpGet]
        public IActionResult UpdateOrder(int ID)
        {
            _logger.LogInformation("Update Customer ID");
            return View("UpdateCustomer", _orderRepository.GetOrderList(ID));
        }

        [HttpPost]
        public IActionResult UpdateOrder(Order order)
        {
            _logger.LogInformation("Update Customer");
            _orderRepository.Update(order);
            return View("List", _orderRepository.GetAllOrderLists());
        }
        //[HttpPost]
        public IActionResult DeleteOrder(int ID)
        {
            _logger.LogInformation("Delete Customer");
            _orderRepository.Delete(_orderRepository.GetOrderList(ID));
            return View("List", _orderRepository.GetAllOrderLists());
        }
    }
}
