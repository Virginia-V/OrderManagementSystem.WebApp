﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OMS.Dal;

#nullable disable

namespace OMS.Dal.Migrations
{
    [DbContext(typeof(OMSDbContext))]
    partial class IMSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OMS.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Machine"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Cover"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Document"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Replacement"
                        });
                });

            modelBuilder.Entity("OMS.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BillingAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("CustomerTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerTypeId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("OMS.Domain.CustomerType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CustomerType");

                    b.HasKey("Id");

                    b.ToTable("CustomerTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Library"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Outreach"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Private School"
                        },
                        new
                        {
                            Id = 4,
                            Type = "Public School"
                        },
                        new
                        {
                            Id = 5,
                            Type = "Referral"
                        },
                        new
                        {
                            Id = 6,
                            Type = "University"
                        },
                        new
                        {
                            Id = 7,
                            Type = "Trade Show"
                        },
                        new
                        {
                            Id = 8,
                            Type = "Agent"
                        },
                        new
                        {
                            Id = 9,
                            Type = "Inbound Lead:Distributor"
                        },
                        new
                        {
                            Id = 10,
                            Type = "Inbound Lead:Facebook"
                        },
                        new
                        {
                            Id = 11,
                            Type = "Inbound Lead:Google"
                        },
                        new
                        {
                            Id = 12,
                            Type = "Dealer - Demo"
                        },
                        new
                        {
                            Id = 13,
                            Type = "Parochial School"
                        },
                        new
                        {
                            Id = 14,
                            Type = "Technical College"
                        },
                        new
                        {
                            Id = 15,
                            Type = "Bookseller"
                        });
                });

            modelBuilder.Entity("OMS.Domain.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DiscountType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("DiscountValue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Discounts");

                    b.HasCheckConstraint("DiscountValue", "DiscountValue BETWEEN 0 AND 1");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiscountType = "Discount 10+boxes",
                            DiscountValue = 0.10m
                        },
                        new
                        {
                            Id = 2,
                            DiscountType = "Discount Starter Kit E-DaVinci",
                            DiscountValue = 0.20m
                        },
                        new
                        {
                            Id = 3,
                            DiscountType = "Discount Starter Kit E-Leo",
                            DiscountValue = 0.20m
                        },
                        new
                        {
                            Id = 4,
                            DiscountType = "Loyalty Discount",
                            DiscountValue = 0.05m
                        });
                });

            modelBuilder.Entity("OMS.Domain.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentStatusId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentTermId")
                        .HasColumnType("int");

                    b.Property<decimal>("ShippingAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DiscountId");

                    b.HasIndex("OrderId");

                    b.HasIndex("PaymentStatusId");

                    b.HasIndex("PaymentTermId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("OMS.Domain.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("OrderTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("PurchaseOrderNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderTypeId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OMS.Domain.OrderedProduct", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderedProducts");
                });

            modelBuilder.Entity("OMS.Domain.OrderType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("OrderType");

                    b.HasKey("Id");

                    b.ToTable("OrderTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "New Order"
                        },
                        new
                        {
                            Id = 2,
                            Type = "ReOrder"
                        });
                });

            modelBuilder.Entity("OMS.Domain.PaymentStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("PaymentStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Status = "Paid"
                        },
                        new
                        {
                            Id = 2,
                            Status = "UnPaid"
                        });
                });

            modelBuilder.Entity("OMS.Domain.PaymentTerm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PaymentTermsType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("PaymentTerms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PaymentTermsType = "Prepaid"
                        },
                        new
                        {
                            Id = 2,
                            PaymentTermsType = "Net 30"
                        },
                        new
                        {
                            Id = 3,
                            PaymentTermsType = "Net 60"
                        },
                        new
                        {
                            Id = 4,
                            PaymentTermsType = "Net 90"
                        },
                        new
                        {
                            Id = 5,
                            PaymentTermsType = "Net 120"
                        });
                });

            modelBuilder.Entity("OMS.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductSKU")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OMS.Domain.Customer", b =>
                {
                    b.HasOne("OMS.Domain.CustomerType", "CustomerType")
                        .WithMany("Customers")
                        .HasForeignKey("CustomerTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerType");
                });

            modelBuilder.Entity("OMS.Domain.Invoice", b =>
                {
                    b.HasOne("OMS.Domain.Discount", "Discount")
                        .WithMany("Invoices")
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OMS.Domain.Order", "Order")
                        .WithMany("Invoices")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OMS.Domain.PaymentStatus", "PaymentStatus")
                        .WithMany("Invoices")
                        .HasForeignKey("PaymentStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OMS.Domain.PaymentTerm", "PaymentTerm")
                        .WithMany("Invoices")
                        .HasForeignKey("PaymentTermId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discount");

                    b.Navigation("Order");

                    b.Navigation("PaymentStatus");

                    b.Navigation("PaymentTerm");
                });

            modelBuilder.Entity("OMS.Domain.Order", b =>
                {
                    b.HasOne("OMS.Domain.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OMS.Domain.OrderType", "OrderType")
                        .WithMany("Orders")
                        .HasForeignKey("OrderTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("OrderType");
                });

            modelBuilder.Entity("OMS.Domain.OrderedProduct", b =>
                {
                    b.HasOne("OMS.Domain.Order", "Order")
                        .WithMany("OrderedProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OMS.Domain.Product", "Product")
                        .WithMany("OrderedProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OMS.Domain.Product", b =>
                {
                    b.HasOne("OMS.Domain.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OMS.Domain.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("OMS.Domain.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("OMS.Domain.CustomerType", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("OMS.Domain.Discount", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("OMS.Domain.Order", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("OrderedProducts");
                });

            modelBuilder.Entity("OMS.Domain.OrderType", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("OMS.Domain.PaymentStatus", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("OMS.Domain.PaymentTerm", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("OMS.Domain.Product", b =>
                {
                    b.Navigation("OrderedProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
