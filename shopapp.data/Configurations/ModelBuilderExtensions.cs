using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Configurations
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
               new Product() { ProductId = 1, Name = "Samsung s5", Url = "samsung-s5", Price = 20000, ImageUrl = "1.jpg", Description = "iyi telefon", IsApproved = true },
               new Product() { ProductId = 2, Name = "Samsung s6", Url = "samsung-s6", Price = 20000, ImageUrl = "2.jpg", Description = "iyi telefon", IsApproved = false },
               new Product() { ProductId = 3, Name = "Samsung s7", Url = "samsung-s7", Price = 20000, ImageUrl = "3.jpg", Description = "iyi telefon", IsApproved = true },
               new Product() { ProductId = 4, Name = "iphone 11 ", Url = "iphone-11", Price = 25000, ImageUrl = "4.jpg", Description = "iyi telefon", IsApproved = false },
               new Product() { ProductId = 5, Name = "iphone 11 ", Url = "iphone-11", Price = 25000, ImageUrl = "4.jpg", Description = "iyi telefon", IsApproved = false }
               );

            builder.Entity<Category>().HasData(
           new Category() { CategoryId = 1, Name = "Telefon", Url = "telefon" },
           new Category() { CategoryId = 2, Name = "Bilgisayar", Url = "bilgisayar" },
           new Category() { CategoryId = 3, Name = "Elektronik", Url = "elektronik" },
           new Category() { CategoryId = 4, Name = "Beyaz Eşya", Url = "beyaz-esya" }
           );

            builder.Entity<ProductCategory>().HasData(
            new ProductCategory() { ProductId = 1, CategoryId = 1 },
            new ProductCategory() { ProductId = 1, CategoryId = 2 },
            new ProductCategory() { ProductId = 1, CategoryId = 3 },
            new ProductCategory() { ProductId = 2, CategoryId = 1 },
            new ProductCategory() { ProductId = 2, CategoryId = 2 },
            new ProductCategory() { ProductId = 2, CategoryId = 3 },
            new ProductCategory() { ProductId = 3, CategoryId = 4 },
            new ProductCategory() { ProductId = 4, CategoryId = 2 },
            new ProductCategory() { ProductId = 5, CategoryId = 3 },
            new ProductCategory() { ProductId = 5, CategoryId = 1 }
            );

        }
    }
}
