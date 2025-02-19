﻿// <auto-generated />
using System;
using FoodCourtBlazor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FoodCourtBlazor.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FoodCourtBlazor.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1e2edff0-663d-425e-92ac-a0b10c8fa3b9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "eb9b2600-2df2-499c-af2b-92c9cb4d3fec",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            Name = "Mohammodullah Emran - Admin",
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEAe5hzpyJTpel+CTUz2M2/a4d80Vn2bm9eeGfjA3rwYfQ6xvOLRZj6bY2ALUbhcRMQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4a1275c8-1f89-447d-bc21-fcf67acd21d6",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "c406b7b4-b242-4b4e-811d-4a678d5fbbc8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8807928c-b08a-4f44-8466-933cd49fae12",
                            Email = "employee@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            Name = "Mohammodullah Emran - Employee",
                            NormalizedEmail = "EMPLOYEE@GMAIL.COM",
                            NormalizedUserName = "EMPLOYEE@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEOtEocoTNqFwbywIBIpMKR71XnUI0EwtzcHPagm4VcIlmFuTLUEoZw+PHyiqTETIow==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cbacca1a-c833-4af0-9cf2-bb711f28451f",
                            TwoFactorEnabled = false,
                            UserName = "employee@gmail.com"
                        });
                });

            modelBuilder.Entity("FoodCourtBlazor.Data.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("11111111-1111-1111-1111-111111111111"),
                            Name = "Fruit"
                        },
                        new
                        {
                            Id = new Guid("22222222-2222-2222-2222-222222222222"),
                            Name = "Vegetable"
                        },
                        new
                        {
                            Id = new Guid("33333333-3333-3333-3333-333333333333"),
                            Name = "Meat"
                        },
                        new
                        {
                            Id = new Guid("44444444-4444-4444-4444-444444444444"),
                            Name = "Dairy"
                        },
                        new
                        {
                            Id = new Guid("55555555-5555-5555-5555-555555555555"),
                            Name = "Bakery"
                        },
                        new
                        {
                            Id = new Guid("66666666-6666-6666-6666-666666666666"),
                            Name = "Beverages"
                        },
                        new
                        {
                            Id = new Guid("77777777-7777-7777-7777-777777777777"),
                            Name = "Snacks"
                        },
                        new
                        {
                            Id = new Guid("88888888-8888-8888-8888-888888888888"),
                            Name = "Frozen Foods"
                        });
                });

            modelBuilder.Entity("FoodCourtBlazor.Data.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int?>("AvailableQuantity")
                        .HasColumnType("integer");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<bool?>("IsAvailable")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("SpecialTag")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("66312610-994e-41f1-8ebb-fd867054ae57"),
                            AvailableQuantity = 100,
                            CategoryId = new Guid("11111111-1111-1111-1111-111111111111"),
                            CreatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1201),
                            Description = "Fresh and sweet yellow bananas, rich in potassium.",
                            ImageUrl = "banana.jpg",
                            IsAvailable = true,
                            Name = "Banana",
                            Price = 1.50m,
                            SpecialTag = "Organic",
                            UpdatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1295)
                        },
                        new
                        {
                            Id = new Guid("ed317e94-146c-412b-955e-9c605ead0e60"),
                            AvailableQuantity = 80,
                            CategoryId = new Guid("11111111-1111-1111-1111-111111111111"),
                            CreatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1402),
                            Description = "Crisp and juicy red apples.",
                            ImageUrl = "apple.jpg",
                            IsAvailable = true,
                            Name = "Apple",
                            Price = 2.00m,
                            SpecialTag = "Fresh Harvest",
                            UpdatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1403)
                        },
                        new
                        {
                            Id = new Guid("20f4b146-3b6d-448c-a81a-75c454ee4ee3"),
                            AvailableQuantity = 150,
                            CategoryId = new Guid("22222222-2222-2222-2222-222222222222"),
                            CreatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1408),
                            Description = "Crunchy orange carrots packed with vitamins.",
                            ImageUrl = "carrot.jpg",
                            IsAvailable = true,
                            Name = "Carrot",
                            Price = 1.20m,
                            SpecialTag = "Farm Fresh",
                            UpdatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1409)
                        },
                        new
                        {
                            Id = new Guid("be0ceeb0-9fa7-4814-9c59-9e0a6b8ce153"),
                            AvailableQuantity = 120,
                            CategoryId = new Guid("22222222-2222-2222-2222-222222222222"),
                            CreatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1446),
                            Description = "Rich in iron and perfect for salads.",
                            ImageUrl = "spinach.jpg",
                            IsAvailable = true,
                            Name = "Spinach",
                            Price = 1.80m,
                            SpecialTag = "Organic",
                            UpdatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1446)
                        },
                        new
                        {
                            Id = new Guid("187d5598-097f-4ce4-85d2-d872d5c7d3f4"),
                            AvailableQuantity = 90,
                            CategoryId = new Guid("33333333-3333-3333-3333-333333333333"),
                            CreatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1452),
                            Description = "Boneless and skinless chicken breast.",
                            ImageUrl = "chicken_breast.jpg",
                            IsAvailable = true,
                            Name = "Chicken Breast",
                            Price = 7.99m,
                            SpecialTag = "Free Range",
                            UpdatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1453)
                        },
                        new
                        {
                            Id = new Guid("5dc730bd-83ec-4842-8570-2768d0936b24"),
                            AvailableQuantity = 70,
                            CategoryId = new Guid("33333333-3333-3333-3333-333333333333"),
                            CreatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1457),
                            Description = "Lean ground beef, perfect for burgers.",
                            ImageUrl = "ground_beef.jpg",
                            IsAvailable = true,
                            Name = "Ground Beef",
                            Price = 9.50m,
                            SpecialTag = "Grass-Fed",
                            UpdatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1458)
                        },
                        new
                        {
                            Id = new Guid("b3b19531-a517-4b72-ad6e-ac22a95ce1db"),
                            AvailableQuantity = 200,
                            CategoryId = new Guid("44444444-4444-4444-4444-444444444444"),
                            CreatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1462),
                            Description = "Fresh cow milk, high in calcium.",
                            ImageUrl = "milk.jpg",
                            IsAvailable = true,
                            Name = "Milk",
                            Price = 3.99m,
                            SpecialTag = "Full Cream",
                            UpdatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1463)
                        },
                        new
                        {
                            Id = new Guid("541a8f53-3998-4a84-b6fc-3bc8d8ffb10d"),
                            AvailableQuantity = 60,
                            CategoryId = new Guid("44444444-4444-4444-4444-444444444444"),
                            CreatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1468),
                            Description = "Sharp and aged cheddar cheese.",
                            ImageUrl = "cheddar_cheese.jpg",
                            IsAvailable = true,
                            Name = "Cheddar Cheese",
                            Price = 6.50m,
                            SpecialTag = "Aged 2 Years",
                            UpdatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1468)
                        },
                        new
                        {
                            Id = new Guid("94c6499d-ee81-47c4-b142-12dc5cd65f8f"),
                            AvailableQuantity = 90,
                            CategoryId = new Guid("55555555-5555-5555-5555-555555555555"),
                            CreatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1473),
                            Description = "Healthy whole wheat bread, rich in fiber.",
                            ImageUrl = "whole_wheat_bread.jpg",
                            IsAvailable = true,
                            Name = "Whole Wheat Bread",
                            Price = 2.50m,
                            SpecialTag = "Freshly Baked",
                            UpdatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1474)
                        },
                        new
                        {
                            Id = new Guid("b9256788-2716-4d63-b36d-5b4035575280"),
                            AvailableQuantity = 75,
                            CategoryId = new Guid("55555555-5555-5555-5555-555555555555"),
                            CreatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1478),
                            Description = "Flaky and buttery croissant.",
                            ImageUrl = "croissant.jpg",
                            IsAvailable = true,
                            Name = "Croissant",
                            Price = 3.00m,
                            SpecialTag = "Handmade",
                            UpdatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1478)
                        },
                        new
                        {
                            Id = new Guid("41cc6d4a-dbe3-4a9a-a11e-c1c024fa084e"),
                            AvailableQuantity = 130,
                            CategoryId = new Guid("66666666-6666-6666-6666-666666666666"),
                            CreatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1483),
                            Description = "Freshly squeezed orange juice, no sugar added.",
                            ImageUrl = "orange_juice.jpg",
                            IsAvailable = true,
                            Name = "Orange Juice",
                            Price = 4.50m,
                            SpecialTag = "100% Pure",
                            UpdatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1484)
                        },
                        new
                        {
                            Id = new Guid("7c72ac9f-2da2-4543-a715-4c6deda3fbbf"),
                            AvailableQuantity = 140,
                            CategoryId = new Guid("77777777-7777-7777-7777-777777777777"),
                            CreatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1491),
                            Description = "Crispy and salted potato chips.",
                            ImageUrl = "chips.jpg",
                            IsAvailable = true,
                            Name = "Chips",
                            Price = 2.00m,
                            SpecialTag = "Classic",
                            UpdatedDate = new DateTime(2025, 2, 19, 12, 1, 15, 286, DateTimeKind.Utc).AddTicks(1492)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "58e29afe-bdbb-43a8-b7fc-c30654fdd2d7",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "d5665d08-f626-4b1e-b41b-a9398f6b1810",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "4f4feff6-16f1-4924-93f8-52641ac79cf0",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1e2edff0-663d-425e-92ac-a0b10c8fa3b9",
                            RoleId = "58e29afe-bdbb-43a8-b7fc-c30654fdd2d7"
                        },
                        new
                        {
                            UserId = "c406b7b4-b242-4b4e-811d-4a678d5fbbc8",
                            RoleId = "4f4feff6-16f1-4924-93f8-52641ac79cf0"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FoodCourtBlazor.Data.Product", b =>
                {
                    b.HasOne("FoodCourtBlazor.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FoodCourtBlazor.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FoodCourtBlazor.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodCourtBlazor.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FoodCourtBlazor.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
