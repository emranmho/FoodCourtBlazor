using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodCourtBlazor.Data.Migrations
{
    /// <inheritdoc />
    public partial class addSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3e95ffcb-4f1b-463b-bc90-c950bef08072", null, "Employee", "EMPLOYEE" },
                    { "6e344404-b5fb-4e1f-8546-74379efc5a93", null, "Customer", "CUSTOMER" },
                    { "98b33dba-71b3-4d10-a0f1-96119b426a84", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "af330fd5-095f-45bf-b9e7-40fd36b2b857", 0, "c7de3bdd-0f88-42bb-b9cf-6296b3c3d013", "admin@gmail.com", true, true, null, "Mohammodullah Emran - Admin", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEEfUxvqB4ARZ5rYJFG9dAmh0hwyuvgMzMluCiEb57Av5Wc9zix7dvS0d3HMqcp8v+A==", null, false, "8cf9f509-bc0d-46c9-9841-454ef0945d3e", false, "admin@gmail.com" },
                    { "baf8b808-7918-4fda-88b3-7675970f19af", 0, "30906e7b-bd97-42ef-a83d-67d625a848f6", "employee@gmail.com", true, true, null, "Mohammodullah Emran - Employee", "EMPLOYEE@GMAIL.COM", "EMPLOYEE@GMAIL.COM", "AQAAAAIAAYagAAAAEIjoR+zocLT3scc2bfReMzYVIq9aoKcZn9JC2/QtSfifjkiX1vJsnXE/r+DpeLH3Zw==", null, false, "763152c0-724d-4943-8d3c-9bf7709c737a", false, "employee@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Fruit" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Vegetable" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Meat" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Dairy" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Bakery" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Beverages" },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "Snacks" },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "Frozen Foods" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "98b33dba-71b3-4d10-a0f1-96119b426a84", "af330fd5-095f-45bf-b9e7-40fd36b2b857" },
                    { "3e95ffcb-4f1b-463b-bc90-c950bef08072", "baf8b808-7918-4fda-88b3-7675970f19af" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableQuantity", "CategoryId", "CreatedDate", "Description", "ImageUrl", "IsAvailable", "Name", "Price", "SpecialTag", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("02f3254d-e174-447f-8ee9-70f1cd792fc7"), 75, new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9667), "Flaky and buttery croissant.", "croissant.jpg", true, "Croissant", 3.00m, "Handmade", new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9668) },
                    { new Guid("0cf87550-90ad-4cbf-a87a-1b20ec4023aa"), 200, new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9652), "Fresh cow milk, high in calcium.", "milk.jpg", true, "Milk", 3.99m, "Full Cream", new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9652) },
                    { new Guid("1f36a06c-c3be-4184-8f71-282871162fc3"), 140, new Guid("77777777-7777-7777-7777-777777777777"), new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9705), "Crispy and salted potato chips.", "chips.jpg", true, "Chips", 2.00m, "Classic", new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9706) },
                    { new Guid("42bfe676-28cb-478e-9506-5a1a9973231d"), 80, new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9618), "Crisp and juicy red apples.", "apple.jpg", true, "Apple", 2.00m, "Fresh Harvest", new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9618) },
                    { new Guid("5d2e6f52-f86d-4b2c-ba4f-d448632a1bf8"), 130, new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9700), "Freshly squeezed orange juice, no sugar added.", "orange_juice.jpg", true, "Orange Juice", 4.50m, "100% Pure", new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9701) },
                    { new Guid("645092f5-b562-4a8d-b9f3-d43d69a07e60"), 60, new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9656), "Sharp and aged cheddar cheese.", "cheddar_cheese.jpg", true, "Cheddar Cheese", 6.50m, "Aged 2 Years", new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9657) },
                    { new Guid("7c0461bf-04b3-4f89-b018-78d401d9a010"), 150, new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9630), "Crunchy orange carrots packed with vitamins.", "carrot.jpg", true, "Carrot", 1.20m, "Farm Fresh", new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9631) },
                    { new Guid("999d576d-05c3-45fa-8daa-12a10980b1be"), 90, new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9662), "Healthy whole wheat bread, rich in fiber.", "whole_wheat_bread.jpg", true, "Whole Wheat Bread", 2.50m, "Freshly Baked", new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9663) },
                    { new Guid("9e145a4b-d16e-449b-9aab-32cd72f083ed"), 120, new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9636), "Rich in iron and perfect for salads.", "spinach.jpg", true, "Spinach", 1.80m, "Organic", new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9636) },
                    { new Guid("9f45b08e-27af-47ea-916d-eba01be1e0ca"), 100, new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9409), "Fresh and sweet yellow bananas, rich in potassium.", "banana.jpg", true, "Banana", 1.50m, "Organic", new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9507) },
                    { new Guid("b4e23795-8423-4b08-8b6b-1b7373926ce4"), 70, new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9646), "Lean ground beef, perfect for burgers.", "ground_beef.jpg", true, "Ground Beef", 9.50m, "Grass-Fed", new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9647) },
                    { new Guid("c9fffa4c-fc78-42f7-a3c7-42a3bcfa9105"), 90, new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9641), "Boneless and skinless chicken breast.", "chicken_breast.jpg", true, "Chicken Breast", 7.99m, "Free Range", new DateTime(2025, 2, 20, 16, 3, 43, 12, DateTimeKind.Utc).AddTicks(9642) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e344404-b5fb-4e1f-8546-74379efc5a93");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "98b33dba-71b3-4d10-a0f1-96119b426a84", "af330fd5-095f-45bf-b9e7-40fd36b2b857" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3e95ffcb-4f1b-463b-bc90-c950bef08072", "baf8b808-7918-4fda-88b3-7675970f19af" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02f3254d-e174-447f-8ee9-70f1cd792fc7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0cf87550-90ad-4cbf-a87a-1b20ec4023aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f36a06c-c3be-4184-8f71-282871162fc3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42bfe676-28cb-478e-9506-5a1a9973231d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d2e6f52-f86d-4b2c-ba4f-d448632a1bf8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("645092f5-b562-4a8d-b9f3-d43d69a07e60"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c0461bf-04b3-4f89-b018-78d401d9a010"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("999d576d-05c3-45fa-8daa-12a10980b1be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e145a4b-d16e-449b-9aab-32cd72f083ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f45b08e-27af-47ea-916d-eba01be1e0ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4e23795-8423-4b08-8b6b-1b7373926ce4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9fffa4c-fc78-42f7-a3c7-42a3bcfa9105"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e95ffcb-4f1b-463b-bc90-c950bef08072");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98b33dba-71b3-4d10-a0f1-96119b426a84");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af330fd5-095f-45bf-b9e7-40fd36b2b857");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "baf8b808-7918-4fda-88b3-7675970f19af");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"));
        }
    }
}
