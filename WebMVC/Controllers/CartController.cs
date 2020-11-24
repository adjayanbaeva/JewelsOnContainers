using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polly.CircuitBreaker;
using WebMVC.Models;
using WebMVC.Services;
using Polly.CircuitBreaker;

namespace WebMVC.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly ICatalogService _catalogService;
        private readonly IIdentityService<ApplicationUser> _identityService;
        public CartController(IIdentityService<ApplicationUser> identityService, ICartService cartService, ICatalogService catalogService)
        {
            _identityService = identityService;
            _cartService = cartService;
            _catalogService = catalogService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Dictionary<string, int> quantities, string action)
        {
            if (action == "[Checkout]")
            {
                return RedirectToAction("Create", "Order");
            }

            try
            {
                var user = _identityService.Get(HttpContext.User);
                var basket = await _cartService.SetQuantities(user, quantities);
                var vm = await _cartService.UpdateCart(basket);
            }
            catch (BrokenCircuitException)
            {
                // Catch error when CartApi is in open circuit mode
                HandleBrokenCircuitException();
            }

            return View();
        }

        private void HandleBrokenCircuitException()
        {
            TempData["BasketInoperativeMsg"] = "cart Service is inoperative, please try later on. (Business Msg Due to Circuit-Breaker)";
        }
    }
}
