namespace CoffeeManagement.Models.Orders
{
    public interface IOrderRepository
    {
        Order GetOrderList(int Id);
        IEnumerable<Order> GetAllOrderLists();
        Order Add(Order cafeList);
        Order Update(Order cafeList);
        Order Delete(Order cafeList);
    }
}
