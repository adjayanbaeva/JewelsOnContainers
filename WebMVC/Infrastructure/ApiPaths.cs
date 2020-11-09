﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Infrastructure
{
    public class ApiPaths
    {
        public static class Catalog
        {
            public static string GetAllCatalogItems(string baseUri, int page, int take, int? brand, int? type)
            {
                var filterQueries = string.Empty;
                if(brand.HasValue || type.HasValue)
                {
                    var brandQueries = (brand.HasValue) ? brand.Value.ToString() : "null";
                    var typeQueries = (type.HasValue) ? type.Value.ToString() : "null";
                    filterQueries = $"/type/{typeQueries}/brand/{brandQueries}";
                }
                
                return $"{baseUri}items{filterQueries}?pageIndex={page}&pageSize={take}";
            }

            public static string GetAllTypes(string baseUri)
            {
                return $"{baseUri}catalogtypes";
            }

            public static string GetAllBrands(string baseUri)
            {
                return $"{baseUri}catalogbrands";
            }
        }

        public static class Basket
        {
            public static string GetBasket(string baseUri, string basketId)
            {
                return $"{baseUri}/{basketId}";
            }

            public static string UpdateBasket(string baseUri)
            {
                return baseUri;
            }

        }
    }
}
