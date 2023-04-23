using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace CoffeeManagement.Models.Orders
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;
        private readonly Order _order;
        private readonly ILogger _logger;
        public OrderRepository(AppDbContext context, Order order, ILogger<OrderRepository> logger)
        {
            _context = context;
            _logger = logger;
            _order = order;
        }
        public Order GetOrderList(int Id)
        {
            _logger.LogInformation("Get Cafe");
            return _context.Orders.Find(Id);
        }
        public IEnumerable<Order> GetAllOrderLists()
        {
            _logger.LogInformation("Get All Cafe");
            return _context.Orders;
        }
        public Order Add(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }

        public Order Update(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
            return order;
        }

        public Order Delete(Order order)
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();
            return order;
        }
    }
}
