using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodCourtBlazor.Data.Migrations
{
    /// <inheritdoc />
    public partial class addProductTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("97a92023-9cb4-43dd-bf61-897e8ed4a120"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9f0844c-6777-43cb-bb69-38b896524b4e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dcd43899-89d8-43e1-889f-75340ab83621"));

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    SpecialTag = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    AvailableQuantity = table.Column<int>(type: "integer", nullable: true),
                    IsAvailable = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("08247416-a6e2-4e77-8137-23433170e7d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("115ad6b1-55c2-4400-96d0-3238d8be2c5a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4f549f0d-516c-4f4b-ae43-b1299255aa24"));

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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("97a92023-9cb4-43dd-bf61-897e8ed4a120"), "Fruit" },
                    { new Guid("a9f0844c-6777-43cb-bb69-38b896524b4e"), "Vegetable" },
                    { new Guid("dcd43899-89d8-43e1-889f-75340ab83621"), "Meat" }
                });
        }
    }
}
