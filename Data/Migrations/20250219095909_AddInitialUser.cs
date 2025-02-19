using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodCourtBlazor.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("115ad6b1-55c2-4400-96d0-3238d8be2c5a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4f549f0d-516c-4f4b-ae43-b1299255aa24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a481659-dd87-41dd-9613-cf0a0f2b6b7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4764d24f-d2c7-4f32-b485-31f8b76c19ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55050e7b-3519-4703-b0d1-243e2a6e5e98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8f6ed36-dd2e-402b-ab55-52b0e3e3dc3a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("08247416-a6e2-4e77-8137-23433170e7d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8647e9ec-e09d-4436-b602-98921dfa4337"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b5febdd7-2c0b-4257-a3dc-6e89488401d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0dd34ca-503f-4376-b895-23e81acf9312"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("08247416-a6e2-4e77-8137-23433170e7d5"), "Vegetable" },
                    { new Guid("115ad6b1-55c2-4400-96d0-3238d8be2c5a"), "Meat" },
                    { new Guid("4f549f0d-516c-4f4b-ae43-b1299255aa24"), "Beverages" },
                    { new Guid("8647e9ec-e09d-4436-b602-98921dfa4337"), "Dairy" },
                    { new Guid("b5febdd7-2c0b-4257-a3dc-6e89488401d8"), "Fruit" },
                    { new Guid("d0dd34ca-503f-4376-b895-23e81acf9312"), "Bakery" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableQuantity", "CategoryId", "CreatedDate", "Description", "ImageUrl", "IsAvailable", "Name", "Price", "SpecialTag", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1a481659-dd87-41dd-9613-cf0a0f2b6b7a"), 50, new Guid("d0dd34ca-503f-4376-b895-23e81acf9312"), new DateTime(2025, 2, 18, 22, 24, 1, 254, DateTimeKind.Utc).AddTicks(8707), "Whole wheat bread", "bread.jpg", true, "Bread", 2.00m, "Freshly Baked", new DateTime(2025, 2, 18, 22, 24, 1, 254, DateTimeKind.Utc).AddTicks(8708) },
                    { new Guid("4764d24f-d2c7-4f32-b485-31f8b76c19ac"), 100, new Guid("b5febdd7-2c0b-4257-a3dc-6e89488401d8"), new DateTime(2025, 2, 18, 22, 24, 1, 254, DateTimeKind.Utc).AddTicks(8467), "Fresh red apples", "apple.jpg", true, "Apple", 2.50m, "Organic", new DateTime(2025, 2, 18, 22, 24, 1, 254, DateTimeKind.Utc).AddTicks(8573) },
                    { new Guid("55050e7b-3519-4703-b0d1-243e2a6e5e98"), 150, new Guid("08247416-a6e2-4e77-8137-23433170e7d5"), new DateTime(2025, 2, 18, 22, 24, 1, 254, DateTimeKind.Utc).AddTicks(8695), "Orange crunchy carrots", "carrot.jpg", true, "Carrot", 1.20m, "Farm Fresh", new DateTime(2025, 2, 18, 22, 24, 1, 254, DateTimeKind.Utc).AddTicks(8696) },
                    { new Guid("a8f6ed36-dd2e-402b-ab55-52b0e3e3dc3a"), 200, new Guid("8647e9ec-e09d-4436-b602-98921dfa4337"), new DateTime(2025, 2, 18, 22, 24, 1, 254, DateTimeKind.Utc).AddTicks(8701), "Fresh cow milk", "milk.jpg", true, "Milk", 3.99m, "Full Cream", new DateTime(2025, 2, 18, 22, 24, 1, 254, DateTimeKind.Utc).AddTicks(8702) }
                });
        }
    }
}
