﻿// <auto-generated />
using System;
using Grup22.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Grup22.Migrations
{
    [DbContext(typeof(KurumsalContext))]
    partial class KurumsalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Grup22.Models.FactoryUser", b =>
                {
                    b.Property<int>("factoryUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("factoryUserAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("factoryUserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("factoryUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("factoryUserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("factoryUserId");

                    b.ToTable("Fabrika Kullanıcısı");
                });

            modelBuilder.Entity("Grup22.Models.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("factoryUserId")
                        .HasColumnType("int");

                    b.Property<string>("productDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<double?>("productPrice")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<int?>("productStock")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("productId");

                    b.HasIndex("factoryUserId");

                    b.ToTable("Ürün");
                });

            modelBuilder.Entity("Grup22.Models.ProductSalesRecord", b =>
                {
                    b.Property<int>("salesRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.Property<int>("salesRecordAmount")
                        .HasColumnType("int");

                    b.Property<bool>("salesRecordConfirmation")
                        .HasColumnType("bit");

                    b.Property<int?>("sellerId")
                        .HasColumnType("int");

                    b.HasKey("salesRecordId");

                    b.HasIndex("productId");

                    b.HasIndex("sellerId");

                    b.ToTable("Ürün Satış Kaydı");
                });

            modelBuilder.Entity("Grup22.Models.Seller", b =>
                {
                    b.Property<int>("sellerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("factoryUserId")
                        .HasColumnType("int");

                    b.Property<string>("sellerAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sellerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("sellerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("sellerPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sellerId");

                    b.HasIndex("factoryUserId");

                    b.ToTable("Bayi");
                });

            modelBuilder.Entity("Grup22.Models.Product", b =>
                {
                    b.HasOne("Grup22.Models.FactoryUser", "productFactoryUser")
                        .WithMany("factoryProducts")
                        .HasForeignKey("factoryUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Grup22.Models.ProductSalesRecord", b =>
                {
                    b.HasOne("Grup22.Models.Product", "salesRecordProduct")
                        .WithMany()
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Grup22.Models.Seller", null)
                        .WithMany("sellerSalesRecord")
                        .HasForeignKey("sellerId");
                });

            modelBuilder.Entity("Grup22.Models.Seller", b =>
                {
                    b.HasOne("Grup22.Models.FactoryUser", "sellerFactoryUser")
                        .WithMany("factorySellers")
                        .HasForeignKey("factoryUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
