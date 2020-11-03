using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CartApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartRepositary _repository;
        public CartController(ICartRepositary repository)
        {
            _repository = repository;
        }
    }
}
