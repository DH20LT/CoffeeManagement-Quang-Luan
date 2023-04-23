using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CoffeeManagement.Models;
using CoffeeManagement.Models.Employees;
using CoffeeManagement.Models.ViewModals;

namespace CoffeeManagement.Component;

[ViewComponent(Name = "NavigationMenuViewComponent")]
public class NavigationMenuViewComponent : ViewComponent
{
    private IEmployeeRepository _repository;

    public NavigationMenuViewComponent(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public IViewComponentResult Invoke()
    {
        return View("~/Views/Shared/Component/NavigationMenuViewComponent/Default.cshtml", _repository.GetAllEmployees());
    }
}
