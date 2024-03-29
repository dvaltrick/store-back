﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SmartStore.DB;

namespace SmartStore.Migrations
{
    [DbContext(typeof(MyAppContext))]
    [Migration("20190706134224_ItemCycle")]
    partial class ItemCycle
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SmartStore.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Icon");

                    b.Property<string>("Name");

                    b.Property<Guid?>("ParentId");

                    b.Property<string>("UpdatadedBy");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SmartStore.Models.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CategoryId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("ShortDescription");

                    b.Property<Guid?>("SpecificationId");

                    b.Property<string>("UpdatadedBy");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SpecificationId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("SmartStore.Models.ItemImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("ImageSource");

                    b.Property<Guid?>("ItemId");

                    b.Property<int>("Sequence");

                    b.Property<string>("UpdatadedBy");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("ItemImages");
                });

            modelBuilder.Entity("SmartStore.Models.ItemPrice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("FinishDate");

                    b.Property<Guid?>("ItemId");

                    b.Property<float>("Price");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("UpdatadedBy");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("ItemPrices");
                });

            modelBuilder.Entity("SmartStore.Models.Specification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Display");

                    b.Property<string>("Name");

                    b.Property<int>("Type");

                    b.Property<string>("UpdatadedBy");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Specifications");
                });

            modelBuilder.Entity("SmartStore.Models.SpecificationUnit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Display");

                    b.Property<string>("Name");

                    b.Property<Guid?>("SpecificationId");

                    b.Property<string>("UpdatadedBy");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("SpecificationId");

                    b.ToTable("SpecificationUnits");
                });

            modelBuilder.Entity("SmartStore.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<int>("Type");

                    b.Property<string>("UpdatadedBy");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SmartStore.Models.Category", b =>
                {
                    b.HasOne("SmartStore.Models.Category", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("SmartStore.Models.Item", b =>
                {
                    b.HasOne("SmartStore.Models.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId");

                    b.HasOne("SmartStore.Models.Specification", "Specification")
                        .WithMany("Items")
                        .HasForeignKey("SpecificationId");
                });

            modelBuilder.Entity("SmartStore.Models.ItemImage", b =>
                {
                    b.HasOne("SmartStore.Models.Item", "Item")
                        .WithMany("Images")
                        .HasForeignKey("ItemId");
                });

            modelBuilder.Entity("SmartStore.Models.ItemPrice", b =>
                {
                    b.HasOne("SmartStore.Models.Item", "Item")
                        .WithMany("PriceHistory")
                        .HasForeignKey("ItemId");
                });

            modelBuilder.Entity("SmartStore.Models.SpecificationUnit", b =>
                {
                    b.HasOne("SmartStore.Models.Specification", "Specification")
                        .WithMany("Units")
                        .HasForeignKey("SpecificationId");
                });
#pragma warning restore 612, 618
        }
    }
}
