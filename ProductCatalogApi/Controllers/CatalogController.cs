﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Data;
using ProductCatalogApi.Domain;

namespace ProductCatalogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly CatalogContext _context;
        public CatalogController(CatalogContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Items([FromQuery]int pageIndex=0, [FromQuery]int pageSize=6)
        {
            var items = await _context.CatalogItems.Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();
            items = ChangePictureUrl(items);
            return Ok(items);
        }

        private List<CatalogItem> ChangePictureUrl(List<CatalogItem> items)
        {
            throw new NotImplementedException();
        }
    }
}
