﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PostOffice.API.Data.Context;

#nullable disable

namespace PostOffice.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens", (string)null);
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles", (string)null);
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Create_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers", (string)null);
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.Area", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("area_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Areas", (string)null);
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.MoneyOrder", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<Guid?>("AppUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MoneyServicePriceid")
                        .HasColumnType("int");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("parcel_type_id")
                        .HasColumnType("int");

                    b.Property<string>("payer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pincode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("receive_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("receiver_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("receiver_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("receiver_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("receiver_national_identity_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("receiver_phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("receiver_pincode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("send_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("sender_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sender_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sender_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sender_national_identity_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sender_phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sender_pincode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("service_id")
                        .HasColumnType("int");

                    b.Property<float>("total_charge")
                        .HasColumnType("real");

                    b.Property<float>("transfer_fee")
                        .HasColumnType("real");

                    b.Property<string>("transfer_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("transfer_value")
                        .HasColumnType("real");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("MoneyServicePriceid");

                    b.HasIndex("pincode");

                    b.ToTable("MoneyOrder");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.MoneyScope", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("Priceid")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("max_value")
                        .HasColumnType("real");

                    b.Property<float>("min_value")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("Priceid");

                    b.ToTable("MoneyScope");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.MoneyServicePrice", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<float>("fee")
                        .HasColumnType("real");

                    b.Property<int>("money_scope_id")
                        .HasColumnType("int");

                    b.Property<int>("zone_type_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("MoneyServicePrice");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.OfficeBranch", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("branch_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("branch_phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("district_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pincode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("pincode");

                    b.ToTable("OfficeBranchs", (string)null);
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.ParcelOrder", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<Guid?>("AppUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ParcelServiceid")
                        .HasColumnType("int");

                    b.Property<int>("ParcelTypeid")
                        .HasColumnType("int");

                    b.Property<string>("desciption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("order_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("parcel_height")
                        .HasColumnType("real");

                    b.Property<float>("parcel_length")
                        .HasColumnType("real");

                    b.Property<int>("parcel_type_id")
                        .HasColumnType("int");

                    b.Property<float>("parcel_weight")
                        .HasColumnType("real");

                    b.Property<float>("parcel_width")
                        .HasColumnType("real");

                    b.Property<string>("payer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("payment_method")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pincode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("receive_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("receiver_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("receiver_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("receiver_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("receiver_phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("receiver_pincode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("send_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("sender_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sender_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sender_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sender_phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sender_pincode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("service_id")
                        .HasColumnType("int");

                    b.Property<float>("total_charge")
                        .HasColumnType("real");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("vpp_value")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("ParcelServiceid");

                    b.HasIndex("ParcelTypeid");

                    b.HasIndex("pincode");

                    b.ToTable("ParcelOrder");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.ParcelService", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("Priceid")
                        .HasColumnType("int");

                    b.Property<int>("delivery_time")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Priceid");

                    b.ToTable("ParcelService");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.ParcelServicePrice", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("parcel_type_id")
                        .HasColumnType("int");

                    b.Property<int>("scope_weight_id")
                        .HasColumnType("int");

                    b.Property<int>("service_id")
                        .HasColumnType("int");

                    b.Property<float>("service_price")
                        .HasColumnType("real");

                    b.Property<int>("zone_type_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("ParcelServicePrice");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.ParcelType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("Priceid")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("max_height")
                        .HasColumnType("real");

                    b.Property<float>("max_length")
                        .HasColumnType("real");

                    b.Property<float>("max_weight")
                        .HasColumnType("real");

                    b.Property<float>("max_width")
                        .HasColumnType("real");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("over_dimension_rate")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("Priceid");

                    b.ToTable("ParcelType");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.Pincode", b =>
                {
                    b.Property<string>("pincode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("area_id")
                        .HasColumnType("int");

                    b.Property<string>("city_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pincode");

                    b.HasIndex("area_id");

                    b.ToTable("Pincodes", (string)null);
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.WeightScope", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("Priceid")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("max_weight")
                        .HasColumnType("real");

                    b.Property<float>("min_weight")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("Priceid");

                    b.ToTable("WeightScope");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.ZoneType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("Priceid")
                        .HasColumnType("int");

                    b.Property<string>("zone_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Priceid");

                    b.ToTable("ZoneType");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.MoneyOrder", b =>
                {
                    b.HasOne("PostOffice.API.Data.Models.AppUser", null)
                        .WithMany("MoneyOrders")
                        .HasForeignKey("AppUserId");

                    b.HasOne("PostOffice.API.Data.Models.MoneyServicePrice", "MoneyServicePrice")
                        .WithMany()
                        .HasForeignKey("MoneyServicePriceid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PostOffice.API.Data.Models.Pincode", "Pincode")
                        .WithMany()
                        .HasForeignKey("pincode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MoneyServicePrice");

                    b.Navigation("Pincode");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.MoneyScope", b =>
                {
                    b.HasOne("PostOffice.API.Data.Models.MoneyServicePrice", "Price")
                        .WithMany("MoneyScopes")
                        .HasForeignKey("Priceid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Price");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.OfficeBranch", b =>
                {
                    b.HasOne("PostOffice.API.Data.Models.Pincode", "Pincode")
                        .WithMany("OfficeBranches")
                        .HasForeignKey("pincode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pincode");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.ParcelOrder", b =>
                {
                    b.HasOne("PostOffice.API.Data.Models.AppUser", null)
                        .WithMany("ParcelOrders")
                        .HasForeignKey("AppUserId");

                    b.HasOne("PostOffice.API.Data.Models.ParcelService", "ParcelService")
                        .WithMany()
                        .HasForeignKey("ParcelServiceid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PostOffice.API.Data.Models.ParcelType", "ParcelType")
                        .WithMany()
                        .HasForeignKey("ParcelTypeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PostOffice.API.Data.Models.Pincode", "Pincode")
                        .WithMany()
                        .HasForeignKey("pincode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParcelService");

                    b.Navigation("ParcelType");

                    b.Navigation("Pincode");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.ParcelService", b =>
                {
                    b.HasOne("PostOffice.API.Data.Models.ParcelServicePrice", "Price")
                        .WithMany("ParcelServices")
                        .HasForeignKey("Priceid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Price");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.ParcelType", b =>
                {
                    b.HasOne("PostOffice.API.Data.Models.ParcelServicePrice", "Price")
                        .WithMany("ParcelTypes")
                        .HasForeignKey("Priceid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Price");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.Pincode", b =>
                {
                    b.HasOne("PostOffice.API.Data.Models.Area", "Area")
                        .WithMany("Pincodes")
                        .HasForeignKey("area_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.WeightScope", b =>
                {
                    b.HasOne("PostOffice.API.Data.Models.ParcelServicePrice", "Price")
                        .WithMany("WeightScopes")
                        .HasForeignKey("Priceid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Price");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.ZoneType", b =>
                {
                    b.HasOne("PostOffice.API.Data.Models.ParcelServicePrice", "Price")
                        .WithMany("ZoneTypes")
                        .HasForeignKey("Priceid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Price");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.AppUser", b =>
                {
                    b.Navigation("MoneyOrders");

                    b.Navigation("ParcelOrders");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.Area", b =>
                {
                    b.Navigation("Pincodes");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.MoneyServicePrice", b =>
                {
                    b.Navigation("MoneyScopes");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.ParcelServicePrice", b =>
                {
                    b.Navigation("ParcelServices");

                    b.Navigation("ParcelTypes");

                    b.Navigation("WeightScopes");

                    b.Navigation("ZoneTypes");
                });

            modelBuilder.Entity("PostOffice.API.Data.Models.Pincode", b =>
                {
                    b.Navigation("OfficeBranches");
                });
#pragma warning restore 612, 618
        }
    }
}
