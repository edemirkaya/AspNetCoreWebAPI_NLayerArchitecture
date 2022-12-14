using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Core;

namespace WebApi.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, Price = 100, Stock = 20, CreateDate = DateTime.Now, Name = "Kalem 1" },
                new Product { Id = 2, CategoryId = 1, Price = 200, Stock = 30, CreateDate = DateTime.Now, Name = "Kalem 2" },
                new Product { Id = 3, CategoryId = 1, Price = 300, Stock = 40, CreateDate = DateTime.Now, Name = "Kalem 3" },
                new Product { Id = 4, CategoryId = 2, Price = 600, Stock = 44, CreateDate = DateTime.Now, Name = "Kitap 1" },
                new Product { Id = 5, CategoryId = 2, Price = 700, Stock = 55, CreateDate = DateTime.Now, Name = "Kitap 2" },
                new Product { Id = 6, CategoryId = 2, Price = 800, Stock = 66, CreateDate = DateTime.Now, Name = "Kitap 3" }
            );
        }
    }
}
