using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Infrastructure;
using WebMVC.Models;
using WebMVC.Models.CartModels;

namespace WebMVC.Services
{
    public class CartService : ICartService
    {
        private readonly IConfiguration _config;
        private IHttpClient _apiClient;
        private readonly string _remoteServiceBaseUrl;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger _logger;
        public CartService(IConfiguration config, IHttpContextAccessor httpContextAccessor, IHttpClient httpClient, ILoggerFactory logger)
        {
            _config = config;
            _remoteServiceBaseUrl = $"{_config["CartUrl"]}/api/cart";
            _httpContextAccessor = httpContextAccessor;
            _apiClient = httpClient;
            _logger = logger.CreateLogger<CartService>();

        }

        public Task<Cart> GetCart(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task AddItemToCart(ApplicationUser user, CartItem product)
        {
            throw new NotImplementedException();
        }

        public Task<Cart> UpdateCart(Cart Cart)
        {
            throw new NotImplementedException();
        }

        public Task<Cart> SetQuantities(ApplicationUser user, Dictionary<string, int> quantities)
        {
            throw new NotImplementedException();
        }

        public Task ClearCart(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        async Task<string> GetUserTokenAsync()
        {
            var context = _httpContextAccessor.HttpContext;
            return await context.GetTokenAsync("access_token");
        }
    }
}
