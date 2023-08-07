﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Concrete.EntityFramework;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entity.Models.BedTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemTypeKey")
                        .HasColumnType("int");

                    b.Property<int?>("ItemTypesId")
                        .HasColumnType("int");

                    b.Property<string>("Title_En")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title_Tr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedByUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ValueTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ValueTypeKey")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemTypesId");

                    b.HasIndex("ValueTypeId");

                    b.ToTable("BedTypes");
                });

            modelBuilder.Entity("Entity.Models.HeatingOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title_En")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title_Tr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedByUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HeatingOptions");
                });

            modelBuilder.Entity("Entity.Models.ItemTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedByUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ItemTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3571),
                            CreatedByUser = "",
                            Name = "Structural Product",
                            UpdatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3580),
                            UpdatedByUser = ""
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3585),
                            CreatedByUser = "",
                            Name = "Built-in Furniture",
                            UpdatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3586),
                            UpdatedByUser = ""
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3587),
                            CreatedByUser = "",
                            Name = "Electronic Product",
                            UpdatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3587),
                            UpdatedByUser = ""
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3588),
                            CreatedByUser = "",
                            Name = "Bed",
                            UpdatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3588),
                            UpdatedByUser = ""
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3589),
                            CreatedByUser = "",
                            Name = "Furniture",
                            UpdatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3589),
                            UpdatedByUser = ""
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3590),
                            CreatedByUser = "",
                            Name = "Floor",
                            UpdatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3590),
                            UpdatedByUser = ""
                        });
                });

            modelBuilder.Entity("Entity.Models.RoomFeatures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title_En")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title_Tr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedByUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoomFeatures");
                });

            modelBuilder.Entity("Entity.Models.Rooms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title_En")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title_Tr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedByUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Entity.Models.Rules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title_En")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title_Tr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedByUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("Entity.Models.ValueType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedByUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ValueTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3762),
                            CreatedByUser = "",
                            Name = "Yes/No",
                            UpdatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3764),
                            UpdatedByUser = ""
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3768),
                            CreatedByUser = "",
                            Name = "Letter",
                            UpdatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3768),
                            UpdatedByUser = ""
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3769),
                            CreatedByUser = "",
                            Name = "Numeric",
                            UpdatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3769),
                            UpdatedByUser = ""
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3770),
                            CreatedByUser = "",
                            Name = "Multiple Selection",
                            UpdatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3770),
                            UpdatedByUser = ""
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3771),
                            CreatedByUser = "",
                            Name = "One choice",
                            UpdatedAt = new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3771),
                            UpdatedByUser = ""
                        });
                });

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
                            Id = "71049519-b93c-4ca4-8b82-d80f979d5734",
                            ConcurrencyStamp = "6deb53b6-6544-4166-8f33-406f5e4a2020",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "80a96350-a3b5-4390-83dc-10dff0e574e9",
                            ConcurrencyStamp = "2e4eed36-8396-4d1e-b936-18cfc8392eec",
                            Name = "Editor",
                            NormalizedName = "EDITOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Entity.Models.BedTypes", b =>
                {
                    b.HasOne("Entity.Models.ItemTypes", null)
                        .WithMany("BedTypes")
                        .HasForeignKey("ItemTypesId");

                    b.HasOne("Entity.Models.ValueType", null)
                        .WithMany("BedTypes")
                        .HasForeignKey("ValueTypeId");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Models.ItemTypes", b =>
                {
                    b.Navigation("BedTypes");
                });

            modelBuilder.Entity("Entity.Models.ValueType", b =>
                {
                    b.Navigation("BedTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
