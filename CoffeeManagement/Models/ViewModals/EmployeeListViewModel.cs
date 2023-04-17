using CoffeeManagement.Models.Employees;

namespace CoffeeManagement.Models.ViewModals
{
    public class EmployeeListViewModel
    {
        public IEnumerable<Employee>? Employees { get; set; }

        public string? PhotoPath { get; set; }
    }
}
