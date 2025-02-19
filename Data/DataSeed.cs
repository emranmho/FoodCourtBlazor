using FoodCourtBlazor.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FoodCourtBlazor.Data;

public static class DataSeed
{
    public static void Seed(ModelBuilder builder)
    {
        //seed roles
        var adminRoleId = Guid.NewGuid().ToString();
        var employeeRoleId = Guid.NewGuid().ToString();

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = adminRoleId, Name = StaticDetails.Admin_Role, NormalizedName = StaticDetails.Admin_Role.ToUpper()
            },
            new IdentityRole
            {
                Id = Guid.NewGuid().ToString(), Name = StaticDetails.Customer_Role,
                NormalizedName = StaticDetails.Customer_Role.ToUpper()
            },
            new IdentityRole
            {
                Id = employeeRoleId, Name = StaticDetails.Employee_Role,
                NormalizedName = StaticDetails.Employee_Role.ToUpper()
            }
        );

        //seed user
        var adminUserId = Guid.NewGuid().ToString();
        var employeeUserId = Guid.NewGuid().ToString();
        var hasher = new PasswordHasher<ApplicationUser>();
        builder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = adminUserId,
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                Name = "Mohammodullah Emran - Admin",
                PasswordHash = hasher.HashPassword(null, "Admin123*"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            },
            new ApplicationUser
            {
                Id = employeeUserId,
                UserName = "employee@gmail.com",
                NormalizedUserName = "EMPLOYEE@GMAIL.COM",
                Email = "employee@gmail.com",
                NormalizedEmail = "EMPLOYEE@GMAIL.COM",
                EmailConfirmed = true,
                Name = "Mohammodullah Emran - Employee",
                PasswordHash = hasher.HashPassword(null, "Admin123*"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            }
        );

        //assign user to role
        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = adminUserId
            },
            new IdentityUserRole<string>
            {
                RoleId = employeeRoleId,
                UserId = employeeUserId
            }
        );

        //seed categories
        var categories = new List<Category>
        {
            new Category { Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), Name = "Fruit" },
            new Category { Id = Guid.Parse("22222222-2222-2222-2222-222222222222"), Name = "Vegetable" },
            new Category { Id = Guid.Parse("33333333-3333-3333-3333-333333333333"), Name = "Meat" },
            new Category { Id = Guid.Parse("44444444-4444-4444-4444-444444444444"), Name = "Dairy" },
            new Category { Id = Guid.Parse("55555555-5555-5555-5555-555555555555"), Name = "Bakery" },
            new Category { Id = Guid.Parse("66666666-6666-6666-6666-666666666666"), Name = "Beverages" },
            new Category { Id = Guid.Parse("77777777-7777-7777-7777-777777777777"), Name = "Snacks" },
            new Category { Id = Guid.Parse("88888888-8888-8888-8888-888888888888"), Name = "Frozen Foods" }
        };

        // Add categories to the builder
        builder.Entity<Category>().HasData(categories);

        //Seed Products

        builder.Entity<Product>().HasData(
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Banana",
                Description = "Fresh and sweet yellow bananas, rich in potassium.",
                SpecialTag = "Organic",
                Price = 1.50m,
                ImageUrl = "banana.jpg",
                CategoryId = Guid.Parse("11111111-1111-1111-1111-111111111111"), // Fruit
                AvailableQuantity = 100,
                IsAvailable = true,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Apple",
                Description = "Crisp and juicy red apples.",
                SpecialTag = "Fresh Harvest",
                Price = 2.00m,
                ImageUrl = "apple.jpg",
                CategoryId = Guid.Parse("11111111-1111-1111-1111-111111111111"), // Fruit
                AvailableQuantity = 80,
                IsAvailable = true,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Carrot",
                Description = "Crunchy orange carrots packed with vitamins.",
                SpecialTag = "Farm Fresh",
                Price = 1.20m,
                ImageUrl = "carrot.jpg",
                CategoryId = Guid.Parse("22222222-2222-2222-2222-222222222222"), // Vegetable
                AvailableQuantity = 150,
                IsAvailable = true,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Spinach",
                Description = "Rich in iron and perfect for salads.",
                SpecialTag = "Organic",
                Price = 1.80m,
                ImageUrl = "spinach.jpg",
                CategoryId = Guid.Parse("22222222-2222-2222-2222-222222222222"), // Vegetable
                AvailableQuantity = 120,
                IsAvailable = true,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Chicken Breast",
                Description = "Boneless and skinless chicken breast.",
                SpecialTag = "Free Range",
                Price = 7.99m,
                ImageUrl = "chicken_breast.jpg",
                CategoryId = Guid.Parse("33333333-3333-3333-3333-333333333333"), // Meat
                AvailableQuantity = 90,
                IsAvailable = true,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Ground Beef",
                Description = "Lean ground beef, perfect for burgers.",
                SpecialTag = "Grass-Fed",
                Price = 9.50m,
                ImageUrl = "ground_beef.jpg",
                CategoryId = Guid.Parse("33333333-3333-3333-3333-333333333333"), // Meat
                AvailableQuantity = 70,
                IsAvailable = true,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Milk",
                Description = "Fresh cow milk, high in calcium.",
                SpecialTag = "Full Cream",
                Price = 3.99m,
                ImageUrl = "milk.jpg",
                CategoryId = Guid.Parse("44444444-4444-4444-4444-444444444444"), // Dairy
                AvailableQuantity = 200,
                IsAvailable = true,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Cheddar Cheese",
                Description = "Sharp and aged cheddar cheese.",
                SpecialTag = "Aged 2 Years",
                Price = 6.50m,
                ImageUrl = "cheddar_cheese.jpg",
                CategoryId = Guid.Parse("44444444-4444-4444-4444-444444444444"), // Dairy
                AvailableQuantity = 60,
                IsAvailable = true,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Whole Wheat Bread",
                Description = "Healthy whole wheat bread, rich in fiber.",
                SpecialTag = "Freshly Baked",
                Price = 2.50m,
                ImageUrl = "whole_wheat_bread.jpg",
                CategoryId = Guid.Parse("55555555-5555-5555-5555-555555555555"), // Bakery
                AvailableQuantity = 90,
                IsAvailable = true,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Croissant",
                Description = "Flaky and buttery croissant.",
                SpecialTag = "Handmade",
                Price = 3.00m,
                ImageUrl = "croissant.jpg",
                CategoryId = Guid.Parse("55555555-5555-5555-5555-555555555555"), // Bakery
                AvailableQuantity = 75,
                IsAvailable = true,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Orange Juice",
                Description = "Freshly squeezed orange juice, no sugar added.",
                SpecialTag = "100% Pure",
                Price = 4.50m,
                ImageUrl = "orange_juice.jpg",
                CategoryId = Guid.Parse("66666666-6666-6666-6666-666666666666"), // Beverages
                AvailableQuantity = 130,
                IsAvailable = true,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Chips",
                Description = "Crispy and salted potato chips.",
                SpecialTag = "Classic",
                Price = 2.00m,
                ImageUrl = "chips.jpg",
                CategoryId = Guid.Parse("77777777-7777-7777-7777-777777777777"), // Snacks
                AvailableQuantity = 140,
                IsAvailable = true,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            }
        );
    }
}