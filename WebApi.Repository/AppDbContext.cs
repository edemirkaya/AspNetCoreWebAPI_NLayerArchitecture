using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Reflection;
using WebApi.Core;

namespace WebApi.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<ProductFeature>().HasData(
            new ProductFeature()
            {
                Id=1,Color="Kırmızı",Height=100,Width=25,ProductId=1
            },
             new ProductFeature()
             {
                Id = 2,Color = "Mavi",Height = 100,Width = 25,ProductId = 2
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
