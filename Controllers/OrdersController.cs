using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderManagementApi.Data;
using OrderManagementApi.Models;

namespace OrderManagementApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpPost("place")]
        public IActionResult PlaceOrder(Order order)
        {
            order.UserName = User.Identity.Name;
            _context.Orders.Add(order);
            _context.SaveChanges();

            return Ok(new
            {
                message = "Order placed successfully",
                order
            });
        }

        [Authorize]
        [HttpGet("all")]
        public IActionResult GetAllOrders()
        {
            var userName = User.Identity.Name;

            var orders = _context.Orders
                                 .Where(o => o.UserName == userName)
                                 .ToList();

            return Ok(orders);
        }
        [Authorize]
        [HttpPut("{id}")]
        public IActionResult UpdateOrder(int id, Order updatedOrder)
        {
            var userName = User.Identity.Name;

            var order = _context.Orders.FirstOrDefault(o => o.Id == id);

            if (order == null)
                return NotFound(new { message = "Order not found" });

            if (order.UserName != userName)
                return Forbid();

            order.ProductName = updatedOrder.ProductName;
            order.Quantity = updatedOrder.Quantity;
            order.UnitPrice = updatedOrder.UnitPrice;


            _context.SaveChanges();

            return Ok(new
            {
                message = "Order updated successfully",
                order
            });
        }

        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var userName = User.Identity.Name;

            var order = _context.Orders.FirstOrDefault(o => o.Id == id);

            if (order == null)
                return NotFound(new { message = "Order not found" });

            if (order.UserName != userName)
                return Forbid();

            _context.Orders.Remove(order);
            _context.SaveChanges();

            return Ok(new { message = "Order deleted successfully" });
        }
    }
}
