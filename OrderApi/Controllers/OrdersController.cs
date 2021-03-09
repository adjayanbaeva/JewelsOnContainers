using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OrderApi.Data;
using OrderApi.Models;

namespace OrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class OrdersController : ControllerBase
    {
        private readonly OrdersContext _ordersContext;
        private readonly IConfiguration _config;
        private readonly ILogger<OrdersController> _logger;
        private IPublishEndpoint _bus;
        public OrdersController(OrdersContext ordersContext,
            ILogger<OrdersController> logger,
            IConfiguration config,
            IPublishEndpoint bus)
        {
            _config = config;
            _ordersContext = ordersContext ?? throw new ArgumentNullException(nameof(ordersContext));
            ordersContext.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
            _logger = logger;
            _bus = bus;
        }

        //POST api/Order/new
        [Route("new")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateOrder([FromBody] Order order)
        {
            order.OrderStatus = OrderStatus.Preparing;
            order.OrderDate = DateTime.UtcNow;

            _ordersContext.Orders.Add(order);
            _ordersContext.OrderItems.AddRange(order.OrderItems);

            try
            {
                await _ordersContext.SaveChangesAsync();
                return Ok(new { order.OrderId });
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}", Name = "GetOrder")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetOrder(int id)
        {

            var item = await _ordersContext.Orders
                .Include(x => x.OrderItems)
                .SingleOrDefaultAsync(ci => ci.OrderId == id);
            if (item != null)
            {
                return Ok(item);
            }

            return NotFound();

        }


        [Route("")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetOrders()
        {
            var orders = await _ordersContext.Orders.ToListAsync();


            return Ok(orders);
        }
    }
}
