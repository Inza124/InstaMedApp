﻿// <auto-generated />
using InstaMedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace InstaMedData.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InstaMedData.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("JoinDate");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("Password");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("Pesel");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Telephone");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int?>("UserRoleId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("UserRoleId")
                        .IsUnique()
                        .HasFilter("[UserRoleId] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("InstaMedData.Models.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DoctorName");

                    b.Property<int?>("T3T4TestId");

                    b.Property<int?>("TSHTestId");

                    b.Property<int?>("visitId");

                    b.HasKey("Id");

                    b.HasIndex("T3T4TestId");

                    b.HasIndex("TSHTestId");

                    b.HasIndex("visitId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("InstaMedData.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccesLevel");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("InstaMedData.Models.T3T4", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DocName");

                    b.Property<decimal>("T3Result");

                    b.Property<decimal>("T4Result");

                    b.Property<bool>("isT3T4");

                    b.HasKey("Id");

                    b.ToTable("T3T4s");
                });

            modelBuilder.Entity("InstaMedData.Models.Temp", b =>
                {
                    b.Property<int>("PrimId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Id");

                    b.Property<int?>("VisitId");

                    b.Property<bool>("isDone");

                    b.HasKey("PrimId");

                    b.HasIndex("VisitId");

                    b.ToTable("Temps");
                });

            modelBuilder.Entity("InstaMedData.Models.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<float>("Price");

                    b.Property<int?>("testTypeCategoryCategoryId");

                    b.Property<int?>("testTypeNameNameId");

                    b.HasKey("Id");

                    b.HasIndex("testTypeCategoryCategoryId");

                    b.HasIndex("testTypeNameNameId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("InstaMedData.Models.TestTypeCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<int>("NameId");

                    b.HasKey("CategoryId");

                    b.ToTable("TestTypeCategories");
                });

            modelBuilder.Entity("InstaMedData.Models.TestTypeName", b =>
                {
                    b.Property<int>("NameId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Name");

                    b.HasKey("NameId");

                    b.ToTable("TestTypeNames");
                });

            modelBuilder.Entity("InstaMedData.Models.TSH", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DocName");

                    b.Property<decimal>("TSHResult");

                    b.Property<bool>("isTSH");

                    b.HasKey("Id");

                    b.ToTable("TSHs");
                });

            modelBuilder.Entity("InstaMedData.Models.Visit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Status");

                    b.Property<string>("UserId");

                    b.Property<DateTime>("dateTime");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("InstaMedData.Models.ApplicationUser", b =>
                {
                    b.HasOne("InstaMedData.Models.Role", "UserRole")
                        .WithOne("User")
                        .HasForeignKey("InstaMedData.Models.ApplicationUser", "UserRoleId");
                });

            modelBuilder.Entity("InstaMedData.Models.Result", b =>
                {
                    b.HasOne("InstaMedData.Models.T3T4", "T3T4Test")
                        .WithMany()
                        .HasForeignKey("T3T4TestId");

                    b.HasOne("InstaMedData.Models.TSH", "TSHTest")
                        .WithMany()
                        .HasForeignKey("TSHTestId");

                    b.HasOne("InstaMedData.Models.Visit", "visit")
                        .WithMany("TestResults")
                        .HasForeignKey("visitId");
                });

            modelBuilder.Entity("InstaMedData.Models.Temp", b =>
                {
                    b.HasOne("InstaMedData.Models.Visit")
                        .WithMany("TestsId")
                        .HasForeignKey("VisitId");
                });

            modelBuilder.Entity("InstaMedData.Models.Test", b =>
                {
                    b.HasOne("InstaMedData.Models.TestTypeCategory", "testTypeCategory")
                        .WithMany()
                        .HasForeignKey("testTypeCategoryCategoryId");

                    b.HasOne("InstaMedData.Models.TestTypeName", "testTypeName")
                        .WithMany()
                        .HasForeignKey("testTypeNameNameId");
                });

            modelBuilder.Entity("InstaMedData.Models.Visit", b =>
                {
                    b.HasOne("InstaMedData.Models.ApplicationUser", "User")
                        .WithMany("visit")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("InstaMedData.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("InstaMedData.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InstaMedData.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("InstaMedData.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
