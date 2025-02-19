using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodCourtBlazor.Data.Migrations
{
    /// <inheritdoc />
    public partial class LoadAllData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92f4f72f-d3b3-4edf-9f66-9bdc697d7c15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "beb135be-8fac-423e-aebe-5d1ef9a7699b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d3d0b30f-1c3e-4151-856c-061fe926d249", "276341ee-3278-468c-9c38-1b37db969a7a" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2da25833-6a5c-4654-ac42-f25bf28b1f10"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7124c08f-282a-4a27-98f5-18ab7cc38ee0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f2679c5-a09d-4146-8357-f05300a99d9a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("715b44f3-50dd-483d-987e-ec340644afff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8fa7d841-002c-4874-b21d-9ba9a7b72197"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d55c327d-20c3-4b56-84f3-181de3c996be"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3d0b30f-1c3e-4151-856c-061fe926d249");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "276341ee-3278-468c-9c38-1b37db969a7a");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("33411465-4b57-4075-8b30-cc03f7ef45c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39a09764-1e8f-4042-92e1-2f0f1d862013"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("89b9e4f8-e7c5-49fb-a9a9-85397eb2cdd0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c19d577c-f08b-4ed4-917e-eb8289d78141"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4f4feff6-16f1-4924-93f8-52641ac79cf0", null, "Employee", "EMPLOYEE" },
                    { "58e29afe-bdbb-43a8-b7fc-c30654fdd2d7", null, "Admin", "ADMIN" },
                    { "d5665d08-f626-4b1e-b41b-a9398f6b1810", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1e2edff0-663d-425e-92ac-a0b10c8fa3b9", 0, "eb9b2600-2df2-499c-af2b-92c9cb4d3fec", "admin@gmail.com", true, true, null, "Mohammodullah Emran - Admin", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEAe5hzpyJTpel+CTUz2M2/a4d80Vn2bm9eeGfjA3rwYfQ6xvOLRZj6bY2ALUbhcRMQ==", null, false, "4a1275c8-1f89-447d-bc21-fcf67acd21d6", false, "admin@gmail.com" },
                    { "c406b7b4-b242-4b4e-811d-4a678d5fbbc8", 0, "8807928c-b08a-4f44-8466-933cd49fae12", "employee@gmail.com", true, true, null, "Mohammodullah Emran - Employee", "EMPLOYEE@GMAIL.COM", "EMPLOYEE@GMAIL.COM", "AQAAAAIAAYagAAAAEOtEocoTNqFwbywIBIpMKR71XnUI0EwtzcHPagm4VcIlmFuTLUEoZw+PHyiqTETIow==", null, false, "cbacca1a-c833-4af0-9cf2-bb711f28451f", false, "employee@gmail.com" }
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
                    { "58e29afe-bdbb-43a8-b7fc-c30654fdd2d7", "1e2edff0-663d-425e-92ac-a0b10c8fa3b9" },
                    { "4f4feff6-16f1-4924-93f8-52641ac79cf0", "c406b7b4-b242-4b4e-811d-4a678d5fbbc8" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableQuantity", "CategoryId", "CreatedDate", "Description", "ImageUrl", "IsAvailable", "Name", "Price", "SpecialTag", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("187d5598-097f-4ce4-85d2-d872d5c7d3f4"), 90, new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1452), "Boneless and skinless chicken breast.", "chicken_breast.jpg", true, "Chicken Breast", 7.99m, "Free Range", new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1453) },
                    { new Guid("20f4b146-3b6d-448c-a81a-75c454ee4ee3"), 150, new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1408), "Crunchy orange carrots packed with vitamins.", "carrot.jpg", true, "Carrot", 1.20m, "Farm Fresh", new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1409) },
                    { new Guid("41cc6d4a-dbe3-4a9a-a11e-c1c024fa084e"), 130, new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1483), "Freshly squeezed orange juice, no sugar added.", "orange_juice.jpg", true, "Orange Juice", 4.50m, "100% Pure", new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1484) },
                    { new Guid("541a8f53-3998-4a84-b6fc-3bc8d8ffb10d"), 60, new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1468), "Sharp and aged cheddar cheese.", "cheddar_cheese.jpg", true, "Cheddar Cheese", 6.50m, "Aged 2 Years", new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1468) },
                    { new Guid("5dc730bd-83ec-4842-8570-2768d0936b24"), 70, new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1457), "Lean ground beef, perfect for burgers.", "ground_beef.jpg", true, "Ground Beef", 9.50m, "Grass-Fed", new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1458) },
                    { new Guid("66312610-994e-41f1-8ebb-fd867054ae57"), 100, new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1201), "Fresh and sweet yellow bananas, rich in potassium.", "banana.jpg", true, "Banana", 1.50m, "Organic", new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1295) },
                    { new Guid("7c72ac9f-2da2-4543-a715-4c6deda3fbbf"), 140, new Guid("77777777-7777-7777-7777-777777777777"), new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1491), "Crispy and salted potato chips.", "chips.jpg", true, "Chips", 2.00m, "Classic", new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1492) },
                    { new Guid("94c6499d-ee81-47c4-b142-12dc5cd65f8f"), 90, new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1473), "Healthy whole wheat bread, rich in fiber.", "whole_wheat_bread.jpg", true, "Whole Wheat Bread", 2.50m, "Freshly Baked", new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1474) },
                    { new Guid("b3b19531-a517-4b72-ad6e-ac22a95ce1db"), 200, new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1462), "Fresh cow milk, high in calcium.", "milk.jpg", true, "Milk", 3.99m, "Full Cream", new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1463) },
                    { new Guid("b9256788-2716-4d63-b36d-5b4035575280"), 75, new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1478), "Flaky and buttery croissant.", "croissant.jpg", true, "Croissant", 3.00m, "Handmade", new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1478) },
                    { new Guid("be0ceeb0-9fa7-4814-9c59-9e0a6b8ce153"), 120, new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1446), "Rich in iron and perfect for salads.", "spinach.jpg", true, "Spinach", 1.80m, "Organic", new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1446) },
                    { new Guid("ed317e94-146c-412b-955e-9c605ead0e60"), 80, new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1402), "Crisp and juicy red apples.", "apple.jpg", true, "Apple", 2.00m, "Fresh Harvest", new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1403) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5665d08-f626-4b1e-b41b-a9398f6b1810");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "58e29afe-bdbb-43a8-b7fc-c30654fdd2d7", "1e2edff0-663d-425e-92ac-a0b10c8fa3b9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4f4feff6-16f1-4924-93f8-52641ac79cf0", "c406b7b4-b242-4b4e-811d-4a678d5fbbc8" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("187d5598-097f-4ce4-85d2-d872d5c7d3f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20f4b146-3b6d-448c-a81a-75c454ee4ee3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41cc6d4a-dbe3-4a9a-a11e-c1c024fa084e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("541a8f53-3998-4a84-b6fc-3bc8d8ffb10d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5dc730bd-83ec-4842-8570-2768d0936b24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66312610-994e-41f1-8ebb-fd867054ae57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c72ac9f-2da2-4543-a715-4c6deda3fbbf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94c6499d-ee81-47c4-b142-12dc5cd65f8f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3b19531-a517-4b72-ad6e-ac22a95ce1db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9256788-2716-4d63-b36d-5b4035575280"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be0ceeb0-9fa7-4814-9c59-9e0a6b8ce153"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed317e94-146c-412b-955e-9c605ead0e60"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f4feff6-16f1-4924-93f8-52641ac79cf0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58e29afe-bdbb-43a8-b7fc-c30654fdd2d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e2edff0-663d-425e-92ac-a0b10c8fa3b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c406b7b4-b242-4b4e-811d-4a678d5fbbc8");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "92f4f72f-d3b3-4edf-9f66-9bdc697d7c15", null, "Customer", "CUSTOMER" },
                    { "beb135be-8fac-423e-aebe-5d1ef9a7699b", null, "Employee", "EMPLOYEE" },
                    { "d3d0b30f-1c3e-4151-856c-061fe926d249", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "276341ee-3278-468c-9c38-1b37db969a7a", 0, "961e53cf-40ff-4957-9839-a02d2763912f", "admin@gmail.com", true, true, null, "Mho Emran", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEPbJobDuRTABaFtrv1gxHk6xk0snMGyv0OpxQ1YUlGbOialdcxtLlehW2bKWwe/wbw==", null, false, "255e984c-2332-4148-8863-04b36eaa18b4", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2da25833-6a5c-4654-ac42-f25bf28b1f10"), "Meat" },
                    { new Guid("33411465-4b57-4075-8b30-cc03f7ef45c5"), "Vegetable" },
                    { new Guid("39a09764-1e8f-4042-92e1-2f0f1d862013"), "Bakery" },
                    { new Guid("7124c08f-282a-4a27-98f5-18ab7cc38ee0"), "Beverages" },
                    { new Guid("89b9e4f8-e7c5-49fb-a9a9-85397eb2cdd0"), "Dairy" },
                    { new Guid("c19d577c-f08b-4ed4-917e-eb8289d78141"), "Fruit" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d3d0b30f-1c3e-4151-856c-061fe926d249", "276341ee-3278-468c-9c38-1b37db969a7a" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableQuantity", "CategoryId", "CreatedDate", "Description", "ImageUrl", "IsAvailable", "Name", "Price", "SpecialTag", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("6f2679c5-a09d-4146-8357-f05300a99d9a"), 50, new Guid("39a09764-1e8f-4042-92e1-2f0f1d862013"), new DateTime(2025, 2, 19, 9, 59, 8, 458, DateTimeKind.Utc).AddTicks(1038), "Whole wheat bread", "bread.jpg", true, "Bread", 2.00m, "Freshly Baked", new DateTime(2025, 2, 19, 9, 59, 8, 458, DateTimeKind.Utc).AddTicks(1039) },
                    { new Guid("715b44f3-50dd-483d-987e-ec340644afff"), 100, new Guid("c19d577c-f08b-4ed4-917e-eb8289d78141"), new DateTime(2025, 2, 19, 9, 59, 8, 458, DateTimeKind.Utc).AddTicks(779), "Fresh red apples", "apple.jpg", true, "Apple", 2.50m, "Organic", new DateTime(2025, 2, 19, 9, 59, 8, 458, DateTimeKind.Utc).AddTicks(889) },
                    { new Guid("8fa7d841-002c-4874-b21d-9ba9a7b72197"), 200, new Guid("89b9e4f8-e7c5-49fb-a9a9-85397eb2cdd0"), new DateTime(2025, 2, 19, 9, 59, 8, 458, DateTimeKind.Utc).AddTicks(1033), "Fresh cow milk", "milk.jpg", true, "Milk", 3.99m, "Full Cream", new DateTime(2025, 2, 19, 9, 59, 8, 458, DateTimeKind.Utc).AddTicks(1033) },
                    { new Guid("d55c327d-20c3-4b56-84f3-181de3c996be"), 150, new Guid("33411465-4b57-4075-8b30-cc03f7ef45c5"), new DateTime(2025, 2, 19, 9, 59, 8, 458, DateTimeKind.Utc).AddTicks(1025), "Orange crunchy carrots", "carrot.jpg", true, "Carrot", 1.20m, "Farm Fresh", new DateTime(2025, 2, 19, 9, 59, 8, 458, DateTimeKind.Utc).AddTicks(1026) }
                });
        }
    }
}
