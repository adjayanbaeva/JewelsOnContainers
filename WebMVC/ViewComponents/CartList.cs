using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Services;

namespace WebMVC.ViewComponents
{
    public class CartList : ViewComponent
    {
        private readonly ICartService _cartSvc;

        public CartList(ICartService cartSvc)
        {
            _cartSvc = cartSvc
        }

    }
}
