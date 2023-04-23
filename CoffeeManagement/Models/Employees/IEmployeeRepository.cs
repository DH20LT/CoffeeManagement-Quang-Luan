using System.Linq;

namespace CoffeeManagement.Models.Employees
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int ID);

        IEnumerable<Employee> GetAllEmployees();

        Employee Add(Employee employee);

        Employee Update(Employee employee);

        Employee Delete(Employee employee);
    }
}
