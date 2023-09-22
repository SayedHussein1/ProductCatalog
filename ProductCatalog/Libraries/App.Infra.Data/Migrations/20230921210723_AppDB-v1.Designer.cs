﻿// <auto-generated />
using System;
using App.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Infra.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230921210723_AppDB-v1")]
    partial class AppDBv1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("App.Domain.Model.AdminPages", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PageTitle")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PageUrl")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AdminPages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 0,
                            Icon = "icon-git-pull-request",
                            PageTitle = "Products",
                            PageUrl = "Products",
                            ParentId = 0
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 1,
                            Icon = "icon-git-pull-request",
                            PageTitle = "Category",
                            PageUrl = "Category",
                            ParentId = 0
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 2,
                            Icon = "icon-git-pull-request",
                            PageTitle = "Language",
                            PageUrl = "Language",
                            ParentId = 0
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 3,
                            Icon = "icon-git-pull-request",
                            PageTitle = "Users",
                            PageUrl = "Users",
                            ParentId = 0
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 4,
                            Icon = "icon-git-pull-request",
                            PageTitle = "Roles",
                            PageUrl = "Groups",
                            ParentId = 0
                        });
                });

            modelBuilder.Entity("App.Domain.Model.AspNetRoleClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("App.Domain.Model.AspNetRoles", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMembers")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NameAr")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("([NormalizedName] IS NOT NULL)");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            IsMembers = false,
                            Name = "Administrator",
                            NameAr = "المدير العام",
                            NormalizedName = "Administrator"
                        });
                });

            modelBuilder.Entity("App.Domain.Model.AspNetUserClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("App.Domain.Model.AspNetUserLogins", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("App.Domain.Model.AspNetUserRoles", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "3497bcc8-dabe-4a3f-a560-37f8fde72ace",
                            RoleId = "1"
                        });
                });

            modelBuilder.Entity("App.Domain.Model.AspNetUserTokens", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("App.Domain.Model.AspNetUsers", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MobileToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("ProfileImageId")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int?>("WorkingLanguageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("([NormalizedUserName] IS NOT NULL)");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "3497bcc8-dabe-4a3f-a560-37f8fde72ace",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "05cb1028-e7c0-4c46-b833-e521d195dbe9",
                            Email = "sayedhussein080@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Sayed Hussein",
                            LockoutEnabled = false,
                            NormalizedEmail = "SAYEDHUSSEIN080@GMAIL.COM",
                            NormalizedUserName = "Sayed_Hussein",
                            PasswordHash = "AQAAAAEAACcQAAAAEIzp5eNM/+PfyG5N2L1XhjQaGlTPB5CW0OETAEi+TmYDLSDuRS8Nstes+jt09As/Yg==",
                            PhoneNumberConfirmed = true,
                            ProfileImageId = 0,
                            SecurityStamp = "U6GO4PPQ726KHDI2UGOFQJ72D3BX6QS4",
                            TwoFactorEnabled = false,
                            UserName = "sayed_hussein"
                        });
                });

            modelBuilder.Entity("App.Domain.Model.Attachment", b =>
                {
                    b.Property<int>("AttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<string>("MimeTypeValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AttachmentId");

                    b.ToTable("Attachments");

                    b.HasData(
                        new
                        {
                            AttachmentId = 1,
                            FileExtension = ".jpg",
                            FileName = "PIC_1",
                            FileSize = 5118L,
                            MimeTypeValue = "image/jpg"
                        },
                        new
                        {
                            AttachmentId = 2,
                            FileExtension = ".jpg",
                            FileName = "PIC_2",
                            FileSize = 5118L,
                            MimeTypeValue = "image/jpg"
                        },
                        new
                        {
                            AttachmentId = 3,
                            FileExtension = ".jpg",
                            FileName = "PIC_3",
                            FileSize = 5118L,
                            MimeTypeValue = "image/jpg"
                        },
                        new
                        {
                            AttachmentId = 4,
                            FileExtension = ".jpg",
                            FileName = "PIC_4",
                            FileSize = 5118L,
                            MimeTypeValue = "image/jpg"
                        });
                });

            modelBuilder.Entity("App.Domain.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<int>("IconId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublish")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UpdateBy")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 9, 22, 0, 7, 23, 375, DateTimeKind.Local).AddTicks(378),
                            IconId = 0,
                            IsDeleted = false,
                            IsPublish = true,
                            Name = "Cat_1",
                            UpdateDate = new DateTime(2023, 9, 22, 0, 7, 23, 376, DateTimeKind.Local).AddTicks(8189)
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2023, 9, 22, 0, 7, 23, 376, DateTimeKind.Local).AddTicks(8390),
                            IconId = 0,
                            IsDeleted = false,
                            IsPublish = true,
                            Name = "Cat_2",
                            UpdateDate = new DateTime(2023, 9, 22, 0, 7, 23, 376, DateTimeKind.Local).AddTicks(8416)
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2023, 9, 22, 0, 7, 23, 376, DateTimeKind.Local).AddTicks(8425),
                            IconId = 0,
                            IsDeleted = false,
                            IsPublish = true,
                            Name = "Cat_3",
                            UpdateDate = new DateTime(2023, 9, 22, 0, 7, 23, 376, DateTimeKind.Local).AddTicks(8428)
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2023, 9, 22, 0, 7, 23, 376, DateTimeKind.Local).AddTicks(8430),
                            IconId = 0,
                            IsDeleted = false,
                            IsPublish = true,
                            Name = "Cat_4",
                            UpdateDate = new DateTime(2023, 9, 22, 0, 7, 23, 376, DateTimeKind.Local).AddTicks(8433)
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2023, 9, 22, 0, 7, 23, 376, DateTimeKind.Local).AddTicks(8435),
                            IconId = 0,
                            IsDeleted = false,
                            IsPublish = true,
                            Name = "Cat_5",
                            UpdateDate = new DateTime(2023, 9, 22, 0, 7, 23, 376, DateTimeKind.Local).AddTicks(8437)
                        });
                });

            modelBuilder.Entity("App.Domain.Model.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublish")
                        .HasColumnType("bit");

                    b.Property<string>("LanguageCulture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Rtl")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Language");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            IsDeleted = false,
                            IsPublish = true,
                            LanguageCulture = "English en-US",
                            Name = "EN",
                            Rtl = false
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            IsDeleted = false,
                            IsPublish = true,
                            LanguageCulture = "Arabic ar-EG",
                            Name = "AR",
                            Rtl = true
                        });
                });

            modelBuilder.Entity("App.Domain.Model.LocaleStringResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("ResourceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResourceValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LocaleStringResource");
                });

            modelBuilder.Entity("App.Domain.Model.LocalizedProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EntityId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("LocaleKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocaleKeyGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocaleValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LocalizedProperty");
                });

            modelBuilder.Entity("App.Domain.Model.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImage");
                });

            modelBuilder.Entity("App.Domain.Model.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateByUserId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<string>("FullDescription")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublish")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSolid")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreateByUserId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreateByUserId = "3497bcc8-dabe-4a3f-a560-37f8fde72ace",
                            CreateDate = new DateTime(2023, 9, 22, 0, 7, 23, 377, DateTimeKind.Local).AddTicks(8525),
                            Duration = 5.0,
                            FullDescription = "Product_1",
                            ImageId = 1,
                            IsDeleted = false,
                            IsPublish = true,
                            IsSolid = false,
                            Price = 200m,
                            ShortDescription = "Product_1",
                            StartDate = new DateTime(2023, 9, 23, 0, 7, 23, 377, DateTimeKind.Local).AddTicks(8696),
                            Title = "Product_1"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreateByUserId = "3497bcc8-dabe-4a3f-a560-37f8fde72ace",
                            CreateDate = new DateTime(2023, 9, 22, 0, 7, 23, 377, DateTimeKind.Local).AddTicks(9285),
                            Duration = 4.0,
                            FullDescription = "Product_2",
                            ImageId = 2,
                            IsDeleted = false,
                            IsPublish = true,
                            IsSolid = false,
                            Price = 100m,
                            ShortDescription = "Product_2",
                            StartDate = new DateTime(2023, 9, 25, 0, 7, 23, 377, DateTimeKind.Local).AddTicks(9297),
                            Title = "Product_2"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreateByUserId = "3497bcc8-dabe-4a3f-a560-37f8fde72ace",
                            CreateDate = new DateTime(2023, 9, 22, 0, 7, 23, 377, DateTimeKind.Local).AddTicks(9318),
                            Duration = 5.0,
                            FullDescription = "Product_3",
                            ImageId = 3,
                            IsDeleted = false,
                            IsPublish = true,
                            IsSolid = false,
                            Price = 250m,
                            ShortDescription = "Product_3",
                            StartDate = new DateTime(2023, 9, 23, 0, 7, 23, 377, DateTimeKind.Local).AddTicks(9320),
                            Title = "Product_3"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            CreateByUserId = "3497bcc8-dabe-4a3f-a560-37f8fde72ace",
                            CreateDate = new DateTime(2023, 9, 22, 0, 7, 23, 377, DateTimeKind.Local).AddTicks(9325),
                            Duration = 6.0,
                            FullDescription = "Product_4",
                            ImageId = 4,
                            IsDeleted = false,
                            IsPublish = true,
                            IsSolid = false,
                            Price = 300m,
                            ShortDescription = "Product_4",
                            StartDate = new DateTime(2023, 9, 28, 0, 7, 23, 377, DateTimeKind.Local).AddTicks(9327),
                            Title = "Product_4"
                        });
                });

            modelBuilder.Entity("App.Domain.Model.ProductsHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MobileAppId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductsHistory");
                });

            modelBuilder.Entity("App.Domain.Model.RolePages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PageId")
                        .HasColumnType("int");

                    b.Property<string>("RoleId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PageId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePages");
                });

            modelBuilder.Entity("App.Domain.Model.SwitchMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("SubCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("SwitchMapping");
                });

            modelBuilder.Entity("App.Domain.Model.AspNetRoleClaims", b =>
                {
                    b.HasOne("App.Domain.Model.AspNetRoles", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("App.Domain.Model.AspNetUserClaims", b =>
                {
                    b.HasOne("App.Domain.Model.AspNetUsers", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("App.Domain.Model.AspNetUserLogins", b =>
                {
                    b.HasOne("App.Domain.Model.AspNetUsers", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("App.Domain.Model.AspNetUserRoles", b =>
                {
                    b.HasOne("App.Domain.Model.AspNetRoles", "Role")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Model.AspNetUsers", "User")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("App.Domain.Model.AspNetUserTokens", b =>
                {
                    b.HasOne("App.Domain.Model.AspNetUsers", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("App.Domain.Model.ProductImage", b =>
                {
                    b.HasOne("App.Domain.Model.Products", "Product")
                        .WithMany("ProductImage")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("App.Domain.Model.Products", b =>
                {
                    b.HasOne("App.Domain.Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Model.AspNetUsers", "CreateByUser")
                        .WithMany()
                        .HasForeignKey("CreateByUserId");

                    b.Navigation("Category");

                    b.Navigation("CreateByUser");
                });

            modelBuilder.Entity("App.Domain.Model.ProductsHistory", b =>
                {
                    b.HasOne("App.Domain.Model.Products", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("App.Domain.Model.RolePages", b =>
                {
                    b.HasOne("App.Domain.Model.AdminPages", "AdminPages")
                        .WithMany("RolePages")
                        .HasForeignKey("PageId")
                        .HasConstraintName("FK_RolePages_AdminPages");

                    b.HasOne("App.Domain.Model.AspNetRoles", "AspNetRoles")
                        .WithMany("RolePages")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_RolePages_AspNetRoles");

                    b.Navigation("AdminPages");

                    b.Navigation("AspNetRoles");
                });

            modelBuilder.Entity("App.Domain.Model.SwitchMapping", b =>
                {
                    b.HasOne("App.Domain.Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("App.Domain.Model.Products", "Product")
                        .WithMany("SwitchMapping")
                        .HasForeignKey("ProductId");

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("App.Domain.Model.AdminPages", b =>
                {
                    b.Navigation("RolePages");
                });

            modelBuilder.Entity("App.Domain.Model.AspNetRoles", b =>
                {
                    b.Navigation("AspNetRoleClaims");

                    b.Navigation("AspNetUserRoles");

                    b.Navigation("RolePages");
                });

            modelBuilder.Entity("App.Domain.Model.AspNetUsers", b =>
                {
                    b.Navigation("AspNetUserClaims");

                    b.Navigation("AspNetUserLogins");

                    b.Navigation("AspNetUserRoles");

                    b.Navigation("AspNetUserTokens");
                });

            modelBuilder.Entity("App.Domain.Model.Products", b =>
                {
                    b.Navigation("ProductImage");

                    b.Navigation("SwitchMapping");
                });
#pragma warning restore 612, 618
        }
    }
}
