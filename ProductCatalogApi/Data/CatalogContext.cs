using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogApi.Data
{
    public class CatalogContext: DbContext
    {
        public CatalogContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public DbSet<CatalogBrand> CatalogBrands { get; set; }
        public DbSet<CatalogType> CatalogTypes { get; set; }
        public DbSet<CatalogItem> CatalogItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogBrand>(e =>
            {
                e.ToTable("CatalogBrands");
                e.Property(b => b.Id)
                    .IsRequired()
                    .UseHiLo("catalog_brand_hilo");

                e.Property(b => b.Brand)
                    .IsRequired()
                    .HasMaxLength(100);
            });
        }

    }
}
