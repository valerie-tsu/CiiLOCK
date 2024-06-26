﻿// <auto-generated />
using CiiLOCK.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CiiLOCK.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240414125715_addProductsToDb")]
    partial class addProductsToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CiiLOCK.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Mother of All Rollers"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Titan Bifold"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Door Lock & Handle"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Additional Hardware"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "SiiGMATIC Testing Services"
                        });
                });

            modelBuilder.Entity("CiiLOCK.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Mother of All Rollers - W1 58 Series - C/S - 40KG ",
                            ListPrice = 5.5,
                            Name = "W2 58 Series - C/S - 100KG",
                            PartCode = "8179-10"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Mother of All Rollers - W2 58 Series - C/S - 100KG",
                            ListPrice = 9.5,
                            Name = "W1 58 Series - C/S - 40KG",
                            PartCode = "8158-202"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Mother of All Rollers - W2 58 Series - S/S - 100KG ",
                            ListPrice = 16.899999999999999,
                            Name = "W2 58 Series - S/S - 100KG",
                            PartCode = "8158-302"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Mother of All Rollers - W3 58 Series - C/S - 150KG",
                            ListPrice = 24.0,
                            Name = "W3 58 Series - C/S - 150KG",
                            PartCode = "8179-10"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Mother of All Rollers - W3 58 Series - S/S - 150KG ",
                            ListPrice = 38.0,
                            Name = "W3 58 Series - S/S - 150KG",
                            PartCode = "8187-302"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "Mother of All Rollers - W5 58 Series C/S 200Kg",
                            ListPrice = 42.0,
                            Name = "W5 58 Series C/S 200Kg",
                            PartCode = "8275-202"
                        });
                });

            modelBuilder.Entity("CiiLOCK.Models.Product", b =>
                {
                    b.HasOne("CiiLOCK.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
