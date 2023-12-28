﻿// <auto-generated />
using System;
using AppTechnoSoft.Interns.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppTechnoSoft.Interns.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231228064356_AddColumnsOnStudent")]
    partial class AddColumnsOnStudent
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppTechnoSoft.Interns.Data.Models.ApplicationUser", b =>
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

            modelBuilder.Entity("AppTechnoSoft.Interns.Data.Models.College", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colleges");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "Bhadrapur, Jhapa",
                            Name = "Mechi Multiple Campus"
                        },
                        new
                        {
                            Id = 2,
                            Location = "Dhankuta",
                            Name = "Dhankuta Multiple Campus"
                        },
                        new
                        {
                            Id = 3,
                            Location = "Dharan",
                            Name = "Central Campus of Technology"
                        },
                        new
                        {
                            Id = 4,
                            Location = "Biratnagar",
                            Name = "Mahendra Morang Adarsha Multiple Campus"
                        },
                        new
                        {
                            Id = 5,
                            Location = "Rajbiraj",
                            Name = "Mahendra Bindeshwori Multiple Campus"
                        },
                        new
                        {
                            Id = 6,
                            Location = "Siraha",
                            Name = "Surya Narayan Satya Na. Mo. Yadav Campus"
                        },
                        new
                        {
                            Id = 7,
                            Location = "Janakpur",
                            Name = "Ramsorup Ramsagar Multiple Campus"
                        },
                        new
                        {
                            Id = 8,
                            Location = "Birgunj",
                            Name = "Thakur Ram Multiple Campus"
                        },
                        new
                        {
                            Id = 9,
                            Location = "Bharatpur",
                            Name = "Birendra Multiple Campus"
                        },
                        new
                        {
                            Id = 10,
                            Location = "Pokhara",
                            Name = "Prithivi Narayan Multiple Campus"
                        },
                        new
                        {
                            Id = 11,
                            Location = "Mahendranagar",
                            Name = "SidhaNath Science Campus"
                        },
                        new
                        {
                            Id = 12,
                            Location = "Nepalgunj",
                            Name = "Mahendra Multiple Campus"
                        },
                        new
                        {
                            Id = 13,
                            Location = "Butwal",
                            Name = "Butwal Multiple Campus"
                        },
                        new
                        {
                            Id = 14,
                            Location = "Palpa",
                            Name = "Tribhuvan Multiple Campus"
                        },
                        new
                        {
                            Id = 15,
                            Location = "Ghantaghar",
                            Name = "Tri-Chandra Multiple Campus"
                        },
                        new
                        {
                            Id = 16,
                            Location = "Lainchour",
                            Name = "Amrit Science Campus"
                        },
                        new
                        {
                            Id = 17,
                            Location = "Patan",
                            Name = "Patan Multiple Campus"
                        },
                        new
                        {
                            Id = 18,
                            Location = "Bhaktapur",
                            Name = "Bhaktapur Multiple Campus"
                        },
                        new
                        {
                            Id = 19,
                            Location = "Bagbazar",
                            Name = "Padma Kanya Multiple Campus"
                        },
                        new
                        {
                            Id = 20,
                            Location = "Ghorahi, Dang",
                            Name = "Mahendra Multiple Campus"
                        },
                        new
                        {
                            Id = 21,
                            Location = "Baglung",
                            Name = "Dhaulagiri Campus"
                        },
                        new
                        {
                            Id = 22,
                            Location = "Gorkha",
                            Name = "Gorkha Campus"
                        },
                        new
                        {
                            Id = 23,
                            Location = "Bhairahawa",
                            Name = "Bhairahawa Multiple Campus"
                        },
                        new
                        {
                            Id = 24,
                            Location = "Biratnagar",
                            Name = "Degree Campus"
                        });
                });

            modelBuilder.Entity("AppTechnoSoft.Interns.Data.Models.FinAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<float>("FeeAmount")
                        .HasColumnType("real");

                    b.Property<float>("PaidAmount")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("FinAccounts");
                });

            modelBuilder.Entity("AppTechnoSoft.Interns.Data.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CollegeId")
                        .HasColumnType("int");

                    b.Property<int>("DbExperience")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FinAccountId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FormSubmitted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TechProgramId")
                        .HasColumnType("int");

                    b.Property<int>("WebExperience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CollegeId");

                    b.HasIndex("FinAccountId");

                    b.HasIndex("TechProgramId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("AppTechnoSoft.Interns.Data.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ColorCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("AppTechnoSoft.Interns.Data.Models.TechProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Affliation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TechPrograms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Affliation = "TU",
                            Name = "BCA"
                        },
                        new
                        {
                            Id = 2,
                            Affliation = "PU",
                            Name = "BCA"
                        },
                        new
                        {
                            Id = 3,
                            Affliation = "TU",
                            Name = "BIT"
                        },
                        new
                        {
                            Id = 4,
                            Affliation = "PU",
                            Name = "BIT"
                        },
                        new
                        {
                            Id = 5,
                            Affliation = "TU",
                            Name = "BIM"
                        },
                        new
                        {
                            Id = 6,
                            Affliation = "TU",
                            Name = "BScIT"
                        },
                        new
                        {
                            Id = 7,
                            Affliation = "PU",
                            Name = "BScIT"
                        });
                });

            modelBuilder.Entity("AppTechnoSoft.Interns.Data.Models.Widget", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HtmlContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Widgets");
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

            modelBuilder.Entity("TagWidget", b =>
                {
                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.Property<int>("WidgetsId")
                        .HasColumnType("int");

                    b.HasKey("TagsId", "WidgetsId");

                    b.HasIndex("WidgetsId");

                    b.ToTable("TagWidget");
                });

            modelBuilder.Entity("AppTechnoSoft.Interns.Data.Models.Student", b =>
                {
                    b.HasOne("AppTechnoSoft.Interns.Data.Models.College", "College")
                        .WithMany()
                        .HasForeignKey("CollegeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppTechnoSoft.Interns.Data.Models.FinAccount", "FinAccount")
                        .WithMany()
                        .HasForeignKey("FinAccountId");

                    b.HasOne("AppTechnoSoft.Interns.Data.Models.TechProgram", "TechProgram")
                        .WithMany()
                        .HasForeignKey("TechProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("College");

                    b.Navigation("FinAccount");

                    b.Navigation("TechProgram");
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
                    b.HasOne("AppTechnoSoft.Interns.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AppTechnoSoft.Interns.Data.Models.ApplicationUser", null)
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

                    b.HasOne("AppTechnoSoft.Interns.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AppTechnoSoft.Interns.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TagWidget", b =>
                {
                    b.HasOne("AppTechnoSoft.Interns.Data.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppTechnoSoft.Interns.Data.Models.Widget", null)
                        .WithMany()
                        .HasForeignKey("WidgetsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
