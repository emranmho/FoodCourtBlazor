using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodCourtBlazor.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            var categories = new List<Category>
            {
                new Category { Id = Guid.NewGuid(), Name = "Fruit" },
                new Category { Id = Guid.NewGuid(), Name = "Vegetable" },
                new Category { Id = Guid.NewGuid(), Name = "Meat" },
                new Category { Id = Guid.NewGuid(), Name = "Dairy" },
                new Category { Id = Guid.NewGuid(), Name = "Bakery" },
                new Category { Id = Guid.NewGuid(), Name = "Beverages" }
            };

            // Add categories to the builder
            builder.Entity<Category>().HasData(categories);

            // Create a dictionary to map category names to their IDs
            var categoryMap = categories.ToDictionary(c => c.Name, c => c.Id);

            // Seeding products by referencing the category IDs
            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Apple",
                    Description = "Fresh red apples",
                    SpecialTag = "Organic",
                    Price = 2.50m,
                    ImageUrl = "apple.jpg",
                    CategoryId = categoryMap["Fruit"],  // Using mapped ID
                    AvailableQuantity = 100,
                    IsAvailable = true,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Carrot",
                    Description = "Orange crunchy carrots",
                    SpecialTag = "Farm Fresh",
                    Price = 1.20m,
                    ImageUrl = "carrot.jpg",
                    CategoryId = categoryMap["Vegetable"],
                    AvailableQuantity = 150,
                    IsAvailable = true,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Milk",
                    Description = "Fresh cow milk",
                    SpecialTag = "Full Cream",
                    Price = 3.99m,
                    ImageUrl = "milk.jpg",
                    CategoryId = categoryMap["Dairy"],
                    AvailableQuantity = 200,
                    IsAvailable = true,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Bread",
                    Description = "Whole wheat bread",
                    SpecialTag = "Freshly Baked",
                    Price = 2.00m,
                    ImageUrl = "bread.jpg",
                    CategoryId = categoryMap["Bakery"],
                    AvailableQuantity = 50,
                    IsAvailable = true,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                }
            );

        }
    }
}
