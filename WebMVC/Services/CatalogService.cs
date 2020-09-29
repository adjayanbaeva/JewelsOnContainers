using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Infrastructure;
using WebMVC.Models;

namespace WebMVC.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly string _baseUri;
        public CatalogService(IConfiguration config)
        {
            _baseUri = $"{ config["CatalogUrl"]}/api/catalog/";
        }
        public async Task<Catalog> GetCatalogItemsAsync(int page, int size)
        {
            var catalogItemsUri = ApiPaths.Catalog.GetAllCatalogItems(_baseUri, page, size);
        }
    }
}
