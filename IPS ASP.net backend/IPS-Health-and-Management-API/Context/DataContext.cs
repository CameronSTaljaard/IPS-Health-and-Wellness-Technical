using IPS_Health_and_Management_API.Models;
using IPS_Health_and_Management_API.Models.Database;
using IPS_Health_and_Management_API.Services;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Reflection.Metadata;

namespace IPS_Health_and_Management_API.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                 .HasMany(e => e.Carts)
                 .WithOne(e => e.User);

            modelBuilder.Entity<Cart>()
                .HasMany(e => e.CartProducts)
                .WithOne(e => e.Cart);

            modelBuilder.Entity<Cart>()
                .HasOne(e => e.Order)
                .WithOne(e => e.Cart)
                .HasForeignKey<Order>(e=>e.CartId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.CartProducts)
                .WithOne(e => e.Product);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductStocks)
                .WithOne(e => e.Product);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithOne(e => e.Category);

            User testUser = new User() {
                Id = 1,
                Username = "testuser",
                Password = new AuthenticateUserService(null,null).HashPassword("123456")
            };



            modelBuilder.Entity<User>().HasData(testUser);

            Category[] categories = new Category[]
            {
                new(){ Id = 1, Name = "Shoes", Description = "This is shoes"},
                new(){ Id = 2, Name = "Shirts", Description = "This is shirts"},
                new(){ Id = 3, Name = "Jackets", Description = "This is jackets"},
                new(){ Id = 4, Name = "Pants", Description = "This is pants"}
            };

            modelBuilder.Entity<Category>().HasData(categories);

            List<Product> products = new List<Product>();
            List<ProductStock> productStocks = new List<ProductStock>();

            using StreamReader reader = new("image_seed_data.json");
            var json = reader.ReadToEnd();
            JsonData d = JsonConvert.DeserializeObject<JsonData>(json);

            string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur vel lectus in ex placerat rutrum eget eget felis. Phasellus semper tempus tortor sed semper. Nulla dapibus, sapien ac sagittis placerat, ipsum felis venenatis risus, nec elementum erat leo id dui. Quisque convallis massa fringilla est accumsan, quis ullamcorper leo fermentum. Etiam vestibulum odio at fringilla molestie.";

            int index = 1;
            int displayIndex = 0;
            foreach(string img in d.Shoes)
            {
                products.Add(new() { Id = index, CategoryId = categories[0].Id, Name = $"Shoe {displayIndex++}", Description = lorem, ShortDescription = "This is a pair of shoes", ImageData = img });
                productStocks.Add(new() { Id = index, DateTaken = DateTime.UtcNow, StockLevel=new Random().Next(1,10), Price = new Random().Next(50, 100), ProductId = index});
                index++;
            }

            displayIndex= 0;
            foreach (string img in d.Shirts)
            {
                products.Add(new() { Id = index, CategoryId = categories[1].Id, Name = $"Shirt {displayIndex++}", Description = lorem, ShortDescription = "This is a shirt", ImageData = img });
                productStocks.Add(new() { Id = index, DateTaken = DateTime.UtcNow, StockLevel = new Random().Next(1, 10), Price = new Random().Next(10, 30), ProductId = index });
                index++;
            }

            displayIndex = 0;
            foreach (string img in d.Jackets)
            {
                products.Add(new() { Id = index, CategoryId = categories[2].Id, Name = $"Jacket {displayIndex++}", Description = lorem, ShortDescription = "This is a jacket", ImageData = img });
                productStocks.Add(new() { Id = index, DateTaken = DateTime.UtcNow, StockLevel=new Random().Next(1,10), Price = new Random().Next(50, 100), ProductId = index});
                index++;
            }

            displayIndex = 0;
            foreach (string img in d.Pants)
            {
                products.Add(new() { Id = index, CategoryId = categories[3].Id, Name = $"Pant {displayIndex++}", Description = lorem, ShortDescription = "This is a pair of pants", ImageData = img });
                productStocks.Add(new() { Id = index, DateTaken = DateTime.UtcNow, StockLevel=new Random().Next(1,10), Price = new Random().Next(10,30), ProductId = index});
                index++;
            }

            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<ProductStock>().HasData(productStocks);

        }
    }
}
