﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SweetCreativity1.Core.Context;

#nullable disable

namespace SweetCreativity1.Core.Migrations
{
    [DbContext(typeof(SweetCreativity1Context))]
    partial class SweetCreativity1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "e98fb12e-cf7b-453a-af1f-62b9f50d0177",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2b2ad491-7046-4ddd-9aca-ece20502a160",
                            Name = "Client",
                            NormalizedName = "CLIENT"
                        },
                        new
                        {
                            Id = "472fe042-5463-4920-8336-777a187b6d54",
                            Name = "Seller",
                            NormalizedName = "SELLER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "09bdcd4c-0816-4813-911c-1b94107d6548",
                            RoleId = "e98fb12e-cf7b-453a-af1f-62b9f50d0177"
                        },
                        new
                        {
                            UserId = "09bdcd4c-0816-4813-911c-1b94107d6548",
                            RoleId = "472fe042-5463-4920-8336-777a187b6d54"
                        },
                        new
                        {
                            UserId = "c23da132-cfc0-4150-b50a-6d31752de429",
                            RoleId = "472fe042-5463-4920-8336-777a187b6d54"
                        },
                        new
                        {
                            UserId = "ac596778-c080-436f-a8a6-9efe0b75d980",
                            RoleId = "2b2ad491-7046-4ddd-9aca-ece20502a160"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("NameCategory")
                        .IsUnique();

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NameCategory = "Торти"
                        },
                        new
                        {
                            Id = 2,
                            NameCategory = "Тістечка"
                        },
                        new
                        {
                            Id = 3,
                            NameCategory = "Цукерки"
                        },
                        new
                        {
                            Id = 4,
                            NameCategory = "Печиво"
                        },
                        new
                        {
                            Id = 5,
                            NameCategory = "Вафлі"
                        });
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ConstructionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAtResponse")
                        .HasColumnType("datetime2");

                    b.Property<string>("TextComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ConstructionId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Construction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Additionaly")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAtOrder")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Form")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameConstruction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserSellerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ViewDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Constructions");
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Listing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CoverPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAtListing")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Product")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Listings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CoverPath = "\\img\\listing\\no_cover.jpg",
                            CreatedAtListing = new DateTime(2023, 12, 15, 21, 21, 10, 147, DateTimeKind.Local).AddTicks(9849),
                            Description = " Це відомий і популярний торт, який складається з тонких шарів бісквіту і вершкового крему.",
                            Location = "Lviv",
                            Price = 165,
                            Product = "Борошно, вершкове масло, яйця, оцет, цукор, ванільний цукор або ванільний екстракт, кукурудзяний крохмаль, вершки, сіль, прикраси (за бажанням).",
                            Title = "Торт Наполеон",
                            UserId = "c23da132-cfc0-4150-b50a-6d31752de429",
                            Weight = 1000
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CoverPath = "\\img\\listing\\no_cover.jpg",
                            CreatedAtListing = new DateTime(2023, 12, 15, 21, 21, 10, 147, DateTimeKind.Local).AddTicks(9916),
                            Description = "Гармонійне поєднання повітряного шоколадного тіста мафіну з ніжно-солодкою вершковою начинкою.",
                            Location = "Rivne",
                            Price = 180,
                            Product = "Борошно пшеничне, цукор-пісок, суміш “Мафін шоколадний”, олія рослинна, меланж, вода. Начинка: згущене молоко “Іриска”з вершками.",
                            Title = "Мафіни",
                            UserId = "09bdcd4c-0816-4813-911c-1b94107d6548",
                            Weight = 80
                        });
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAtOrder")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerNumber")
                        .HasColumnType("int");

                    b.Property<int?>("ListingId")
                        .HasColumnType("int");

                    b.Property<string>("ListingPhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameOrder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PriceOne")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ListingId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAtOrder = new DateTime(2023, 12, 15, 21, 21, 10, 147, DateTimeKind.Local).AddTicks(9985),
                            CustomerNumber = 985684335,
                            ListingId = 1,
                            NameOrder = "Торт Наполеон",
                            PriceOne = 0m,
                            Quantity = 1,
                            TotalPrice = 250m,
                            UserId = "ac596778-c080-436f-a8a6-9efe0b75d980"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAtOrder = new DateTime(2023, 12, 15, 21, 21, 10, 147, DateTimeKind.Local).AddTicks(9993),
                            CustomerNumber = 985688735,
                            ListingId = 2,
                            NameOrder = "Торт Спартак",
                            PriceOne = 0m,
                            Quantity = 1,
                            TotalPrice = 400m,
                            UserId = "09bdcd4c-0816-4813-911c-1b94107d6548"
                        });
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.Property<int>("RatingPoint")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ListingId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Response", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAtResponse")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ListingId")
                        .HasColumnType("int");

                    b.Property<string>("TextResponse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ListingId");

                    b.HasIndex("UserId");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StatusName = "Прийнято"
                        },
                        new
                        {
                            Id = 2,
                            StatusName = "Виконується"
                        },
                        new
                        {
                            Id = 3,
                            StatusName = "Не прийнято"
                        });
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UrlSocialnetwork")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "09bdcd4c-0816-4813-911c-1b94107d6548",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3edc4df2-017f-410e-b3d8-77c7701325a5",
                            CoverPath = "\\img\\user\\no_cover.jpg",
                            Email = "admin@sweetcreativity.com",
                            EmailConfirmed = true,
                            FullName = "Тетяна Бондар",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@SWEETCREATIVITY.COM",
                            NormalizedUserName = "ADMIN@SWEETCREATIVITY.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEIaA9PIDsjP9t2/q+GyuwdC9a5odEczQiPVjNs6WScr3YqpSGRT+EkRBD16ayPLNyg==",
                            PhoneNumber = 985674335,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "aac24e6d-b5b6-4a2f-8d06-2f59c8ac50a3",
                            TwoFactorEnabled = false,
                            UrlSocialnetwork = "@taniabondar23",
                            UserName = "admin@sweetcreativity.com"
                        },
                        new
                        {
                            Id = "ac596778-c080-436f-a8a6-9efe0b75d980",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "28409c67-f210-49d1-a542-b0658dfd31be",
                            CoverPath = "\\img\\user\\no_cover.jpg",
                            Email = "client@sweetcreativity.com",
                            EmailConfirmed = true,
                            FullName = "Олена Ткачук",
                            LockoutEnabled = false,
                            NormalizedEmail = "CLIENT@SWEETCREATIVITY.COM",
                            NormalizedUserName = "CLIENT@SWEETCREATIVITY.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAELq1vCnJeCLBZEfwVoM0t3EbpP4UK2QG8b1TxZmnHrOn3xWLeEChHid8uF1fi5nYGQ==",
                            PhoneNumber = 986390482,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "faa34661-00fc-4abc-ac6d-5e990a55df6f",
                            TwoFactorEnabled = false,
                            UrlSocialnetwork = "@olena_tkachuk",
                            UserName = "client@sweetcreativity.com"
                        },
                        new
                        {
                            Id = "c23da132-cfc0-4150-b50a-6d31752de429",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fbb50313-aa23-410d-aa52-23cdef0a9d26",
                            CoverPath = "\\img\\user\\no_cover.jpg",
                            Email = "seller@sweetcreativity.com",
                            EmailConfirmed = true,
                            FullName = "Адріан Мельник",
                            LockoutEnabled = false,
                            NormalizedEmail = "SELLER@SWEETCREATIVITY.COM",
                            NormalizedUserName = "SELLER@SWEETCREATIVITY.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEGVom12j9tQ9BXglkzuQKKH5D13Xu4xdtuRVRJ/vOPzj15gfXvO6f14Ya6xQTF+OHA==",
                            PhoneNumber = 984568310,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "de70b472-0782-4d08-b139-cf7f98ceea15",
                            TwoFactorEnabled = false,
                            UrlSocialnetwork = "@adriannmelnykk",
                            UserName = "seller@sweetcreativity.com"
                        });
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
                    b.HasOne("SweetCreativity1.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SweetCreativity1.Core.Entities.User", null)
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

                    b.HasOne("SweetCreativity1.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SweetCreativity1.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Comment", b =>
                {
                    b.HasOne("SweetCreativity1.Core.Entities.Construction", "Construction")
                        .WithMany("Comments")
                        .HasForeignKey("ConstructionId");

                    b.HasOne("SweetCreativity1.Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Construction");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Construction", b =>
                {
                    b.HasOne("SweetCreativity1.Core.Entities.Status", "Status")
                        .WithMany("Constructions")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SweetCreativity1.Core.Entities.User", "User")
                        .WithMany("Constructions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Listing", b =>
                {
                    b.HasOne("SweetCreativity1.Core.Entities.Category", "Category")
                        .WithMany("Listings")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SweetCreativity1.Core.Entities.User", "User")
                        .WithMany("Listings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Order", b =>
                {
                    b.HasOne("SweetCreativity1.Core.Entities.Listing", "Listing")
                        .WithMany("Orders")
                        .HasForeignKey("ListingId");

                    b.HasOne("SweetCreativity1.Core.Entities.Status", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SweetCreativity1.Core.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Listing");

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Rating", b =>
                {
                    b.HasOne("SweetCreativity1.Core.Entities.Listing", "Listing")
                        .WithMany("Ratings")
                        .HasForeignKey("ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SweetCreativity1.Core.Entities.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId");

                    b.Navigation("Listing");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Response", b =>
                {
                    b.HasOne("SweetCreativity1.Core.Entities.Listing", "Listing")
                        .WithMany("Responses")
                        .HasForeignKey("ListingId");

                    b.HasOne("SweetCreativity1.Core.Entities.User", "User")
                        .WithMany("Responses")
                        .HasForeignKey("UserId");

                    b.Navigation("Listing");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Category", b =>
                {
                    b.Navigation("Listings");
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Construction", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Listing", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Ratings");

                    b.Navigation("Responses");
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.Status", b =>
                {
                    b.Navigation("Constructions");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("SweetCreativity1.Core.Entities.User", b =>
                {
                    b.Navigation("Constructions");

                    b.Navigation("Listings");

                    b.Navigation("Orders");

                    b.Navigation("Ratings");

                    b.Navigation("Responses");
                });
#pragma warning restore 612, 618
        }
    }
}
