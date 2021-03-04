using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Stripe;
using WebMVC.Models;
using Order = WebMVC.Models.OrderModels.Order;
using WebMVC.Services;

namespace WebMVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICartService _cartSvc;
        private readonly IOrderService _orderSvc;
        private readonly IIdentityService<ApplicationUser> _identitySvc;
        private readonly ILogger<OrderController> _logger;
        private readonly IConfiguration _config;
        public OrderController(IConfiguration config,
            ILogger<OrderController> logger,
            IOrderService orderSvc,
            ICartService cartSvc,
            IIdentityService<ApplicationUser> identitySvc)
        {
            _identitySvc = identitySvc;
            _orderSvc = orderSvc;
            _cartSvc = cartSvc;
            _logger = logger;
            _config = config;
        }

        public async Task<IActionResult> Create(Order frmOrder)
        {

            if (ModelState.IsValid)
            {
                var user = _identitySvc.Get(HttpContext.User);

                Order order = frmOrder;

                order.UserName = user.Email;
                order.BuyerId = user.Email;

                var options = new RequestOptions
                {
                    ApiKey = _config["StripePrivateKey"]
                };

                var chargeOptions = new ChargeCreateOptions()

                {
                    Amount = (int)(order.OrderTotal * 100),
                    Currency = "usd",
                    Source = order.StripeToken,
                    Description = string.Format("Order Payment {0}", order.UserName),
                    ReceiptEmail = order.UserName,

                };
            }
        }
                public IActionResult Index()
        {
            return View();
        }
    }
}
