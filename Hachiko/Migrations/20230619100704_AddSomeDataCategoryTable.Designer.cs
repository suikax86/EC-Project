﻿// <auto-generated />
using Hachiko.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hachiko.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230619100704_AddSomeDataCategoryTable")]
    partial class AddSomeDataCategoryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hachiko.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOder = 1,
                            Name = "Laptop"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOder = 2,
                            Name = "RAM"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOder = 2,
                            Name = "Monitor"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOder = 2,
                            Name = "Gear"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOder = 3,
                            Name = "HDD"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOder = 3,
                            Name = "SSD"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}