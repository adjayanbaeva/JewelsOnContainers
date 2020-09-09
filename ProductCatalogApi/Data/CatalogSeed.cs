using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogApi.Data
{
    public static class CatalogSeed
    {
        public static void Seed(CatalogContext context)
        {
            context.Database.Migrate();
            if(!context.CatalogBrands.Any())
            {
                context.CatalogBrands.AddRange(GetPreConfiguredCatalogBrands());
                context.SaveChanges();
            }

            if (!context.CatalogTypes.Any())
            {
                context.CatalogTypes.AddRange(GetPreConfiguredCatalogTypes());
                context.SaveChanges();
            }


        }

        private static IEnumerable<CatalogType> GetPreConfiguredCatalogTypes()
        {
            return new List<CatalogType>
            {
                new CatalogType {Type="Engagement Ring"},
                new CatalogType {Type="Wedding Ring"},
                new CatalogType {Type="Fashion Ring"}
            };
        }

        private static IEnumerable<CatalogBrand> GetPreConfiguredCatalogBrands()
        {
            return new List<CatalogBrand>
            {
                new CatalogBrand{Brand="Tiffany & Co."},
                new CatalogBrand{Brand="DeBeers"},
                new CatalogBrand{Brand="Graff"}
            }
        }
    }
}
