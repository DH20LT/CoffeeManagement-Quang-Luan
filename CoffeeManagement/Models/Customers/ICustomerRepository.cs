using System.Linq;

namespace CoffeeManagement.Models.Customers
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int ID);

        IEnumerable<Customer> GetAllCustomers();

        Customer Add(Customer customer);

        Customer Update(Customer customer);

        Customer Delete(Customer customer);
    }
}
