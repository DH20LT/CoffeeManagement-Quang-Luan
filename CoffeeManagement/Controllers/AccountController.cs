using Microsoft.AspNetCore.Mvc;

namespace CoffeeManagement.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
