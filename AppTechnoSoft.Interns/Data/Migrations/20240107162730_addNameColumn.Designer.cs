﻿// <auto-generated />
using System;
using AppTechnoSoft.Interns.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppTechnoSoft.Interns.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240107162730_addNameColumn")]
    partial class addNameColumn
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

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("AppTechnoSoft.Interns.Data.Models.Batch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Batches");
                });

            modelBuilder.Entity("AppTechnoSoft.Interns.Data.Models.College", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

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
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9021),
                            Location = "Bhadrapur, Jhapa",
                            Name = "Mechi Multiple Campus"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9050),
                            Location = "Dhankuta",
                            Name = "Dhankuta Multiple Campus"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9051),
                            Location = "Dharan",
                            Name = "Central Campus of Technology"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9053),
                            Location = "Biratnagar",
                            Name = "Mahendra Morang Adarsha Multiple Campus"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9054),
                            Location = "Rajbiraj",
                            Name = "Mahendra Bindeshwori Multiple Campus"
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9055),
                            Location = "Siraha",
                            Name = "Surya Narayan Satya Na. Mo. Yadav Campus"
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9056),
                            Location = "Janakpur",
                            Name = "Ramsorup Ramsagar Multiple Campus"
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9057),
                            Location = "Birgunj",
                            Name = "Thakur Ram Multiple Campus"
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9058),
                            Location = "Bharatpur",
                            Name = "Birendra Multiple Campus"
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9059),
                            Location = "Pokhara",
                            Name = "Prithivi Narayan Multiple Campus"
                        },
                        new
                        {
                            Id = 11,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9060),
                            Location = "Mahendranagar",
                            Name = "SidhaNath Science Campus"
                        },
                        new
                        {
                            Id = 12,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9061),
                            Location = "Nepalgunj",
                            Name = "Mahendra Multiple Campus"
                        },
                        new
                        {
                            Id = 13,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9062),
                            Location = "Butwal",
                            Name = "Butwal Multiple Campus"
                        },
                        new
                        {
                            Id = 14,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9063),
                            Location = "Palpa",
                            Name = "Tribhuvan Multiple Campus"
                        },
                        new
                        {
                            Id = 15,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9064),
                            Location = "Ghantaghar",
                            Name = "Tri-Chandra Multiple Campus"
                        },
                        new
                        {
                            Id = 16,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9065),
                            Location = "Lainchour",
                            Name = "Amrit Science Campus"
                        },
                        new
                        {
                            Id = 17,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9066),
                            Location = "Patan",
                            Name = "Patan Multiple Campus"
                        },
                        new
                        {
                            Id = 18,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9067),
                            Location = "Bhaktapur",
                            Name = "Bhaktapur Multiple Campus"
                        },
                        new
                        {
                            Id = 19,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9068),
                            Location = "Bagbazar",
                            Name = "Padma Kanya Multiple Campus"
                        },
                        new
                        {
                            Id = 20,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9069),
                            Location = "Ghorahi, Dang",
                            Name = "Mahendra Multiple Campus"
                        },
                        new
                        {
                            Id = 21,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9098),
                            Location = "Baglung",
                            Name = "Dhaulagiri Campus"
                        },
                        new
                        {
                            Id = 22,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9099),
                            Location = "Gorkha",
                            Name = "Gorkha Campus"
                        },
                        new
                        {
                            Id = 23,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9100),
                            Location = "Bhairahawa",
                            Name = "Bhairahawa Multiple Campus"
                        },
                        new
                        {
                            Id = 24,
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9101),
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

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<float>("FeeAmount")
                        .HasColumnType("real");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PaidAmount")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("FinAccounts");
                });

            modelBuilder.Entity("AppTechnoSoft.Interns.Data.Models.Student", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CollegeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DbExperience")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FinAccountId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FormSubmitted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("TechProgramId")
                        .HasColumnType("int");

                    b.Property<int>("WebExperience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CollegeId");

                    b.HasIndex("FinAccountId");

                    b.HasIndex("TeamId");

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

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ColorCode = "",
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9475),
                            Description = "Specific module/sub-module for a training course",
                            Name = "Module"
                        },
                        new
                        {
                            Id = 2,
                            ColorCode = "",
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9479),
                            Description = "Single display item for home page",
                            Name = "CarouselItem"
                        });
                });

            modelBuilder.Entity("AppTechnoSoft.Interns.Data.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BatchId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BatchId");

                    b.ToTable("Teams");
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

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
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
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9431),
                            Name = "BCA"
                        },
                        new
                        {
                            Id = 2,
                            Affliation = "PU",
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9435),
                            Name = "BCA"
                        },
                        new
                        {
                            Id = 3,
                            Affliation = "TU",
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9436),
                            Name = "BIT"
                        },
                        new
                        {
                            Id = 4,
                            Affliation = "PU",
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9437),
                            Name = "BIT"
                        },
                        new
                        {
                            Id = 5,
                            Affliation = "TU",
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9438),
                            Name = "BIM"
                        },
                        new
                        {
                            Id = 6,
                            Affliation = "TU",
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9439),
                            Name = "BScIT"
                        },
                        new
                        {
                            Id = 7,
                            Affliation = "PU",
                            Created = new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9440),
                            Name = "BScIT"
                        });
                });

            modelBuilder.Entity("AppTechnoSoft.Interns.Data.Models.Widget", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HtmlContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("Roles", (string)null);
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

                    b.ToTable("RoleClaims", (string)null);
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

                    b.ToTable("UserClaims", (string)null);
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

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole", (string)null);
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

                    b.ToTable("UserTokens", (string)null);
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
                    b.HasOne("AppTechnoSoft.Interns.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("AppTechnoSoft.Interns.Data.Models.College", "College")
                        .WithMany()
                        .HasForeignKey("CollegeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppTechnoSoft.Interns.Data.Models.FinAccount", "FinAccount")
                        .WithMany()
                        .HasForeignKey("FinAccountId");

                    b.HasOne("AppTechnoSoft.Interns.Data.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.HasOne("AppTechnoSoft.Interns.Data.Models.TechProgram", "TechProgram")
                        .WithMany()
                        .HasForeignKey("TechProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("College");

                    b.Navigation("FinAccount");

                    b.Navigation("Team");

                    b.Navigation("TechProgram");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AppTechnoSoft.Interns.Data.Models.Team", b =>
                {
                    b.HasOne("AppTechnoSoft.Interns.Data.Models.Batch", "Batch")
                        .WithMany()
                        .HasForeignKey("BatchId");

                    b.Navigation("Batch");
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
