using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppTechnoSoft.Interns.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Batches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colleges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colleges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeeAmount = table.Column<float>(type: "real", nullable: false),
                    Discount = table.Column<float>(type: "real", nullable: false),
                    PaidAmount = table.Column<float>(type: "real", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TechPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Affliation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechPrograms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Widgets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HtmlContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Widgets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRole_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagWidget",
                columns: table => new
                {
                    TagsId = table.Column<int>(type: "int", nullable: false),
                    WidgetsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagWidget", x => new { x.TagsId, x.WidgetsId });
                    table.ForeignKey(
                        name: "FK_TagWidget_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagWidget_Widgets_WidgetsId",
                        column: x => x.WidgetsId,
                        principalTable: "Widgets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebExperience = table.Column<int>(type: "int", nullable: false),
                    DbExperience = table.Column<int>(type: "int", nullable: false),
                    FormSubmitted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ProfileImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollegeId = table.Column<int>(type: "int", nullable: false),
                    TechProgramId = table.Column<int>(type: "int", nullable: false),
                    FinAccountId = table.Column<int>(type: "int", nullable: true),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Colleges_CollegeId",
                        column: x => x.CollegeId,
                        principalTable: "Colleges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_FinAccounts_FinAccountId",
                        column: x => x.FinAccountId,
                        principalTable: "FinAccounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Students_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Students_TechPrograms_TechProgramId",
                        column: x => x.TechProgramId,
                        principalTable: "TechPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "Id", "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy", "Location", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5412), null, null, null, "Bhadrapur, Jhapa", "Mechi Multiple Campus" },
                    { 2, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5443), null, null, null, "Dhankuta", "Dhankuta Multiple Campus" },
                    { 3, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5445), null, null, null, "Dharan", "Central Campus of Technology" },
                    { 4, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5447), null, null, null, "Biratnagar", "Mahendra Morang Adarsha Multiple Campus" },
                    { 5, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5449), null, null, null, "Rajbiraj", "Mahendra Bindeshwori Multiple Campus" },
                    { 6, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5451), null, null, null, "Siraha", "Surya Narayan Satya Na. Mo. Yadav Campus" },
                    { 7, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5452), null, null, null, "Janakpur", "Ramsorup Ramsagar Multiple Campus" },
                    { 8, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5454), null, null, null, "Birgunj", "Thakur Ram Multiple Campus" },
                    { 9, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5456), null, null, null, "Bharatpur", "Birendra Multiple Campus" },
                    { 10, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5457), null, null, null, "Pokhara", "Prithivi Narayan Multiple Campus" },
                    { 11, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5459), null, null, null, "Mahendranagar", "SidhaNath Science Campus" },
                    { 12, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5460), null, null, null, "Nepalgunj", "Mahendra Multiple Campus" },
                    { 13, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5462), null, null, null, "Butwal", "Butwal Multiple Campus" },
                    { 14, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5463), null, null, null, "Palpa", "Tribhuvan Multiple Campus" },
                    { 15, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5465), null, null, null, "Ghantaghar", "Tri-Chandra Multiple Campus" },
                    { 16, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5466), null, null, null, "Lainchour", "Amrit Science Campus" },
                    { 17, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5468), null, null, null, "Patan", "Patan Multiple Campus" },
                    { 18, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5469), null, null, null, "Bhaktapur", "Bhaktapur Multiple Campus" },
                    { 19, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5471), null, null, null, "Bagbazar", "Padma Kanya Multiple Campus" },
                    { 20, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5472), null, null, null, "Ghorahi, Dang", "Mahendra Multiple Campus" },
                    { 21, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5474), null, null, null, "Baglung", "Dhaulagiri Campus" },
                    { 22, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5475), null, null, null, "Gorkha", "Gorkha Campus" },
                    { 23, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5476), null, null, null, "Bhairahawa", "Bhairahawa Multiple Campus" },
                    { 24, new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5478), null, null, null, "Biratnagar", "Degree Campus" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "ColorCode", "Created", "CreatedBy", "Description", "LastUpdated", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(6030), null, "Specific module/sub-module for a training course", null, null, "Module" },
                    { 2, "", new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(6035), null, "Single display item for home page", null, null, "CarouselItem" }
                });

            migrationBuilder.InsertData(
                table: "TechPrograms",
                columns: new[] { "Id", "Affliation", "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 1, "TU", new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5956), null, null, null, "BCA" },
                    { 2, "PU", new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5962), null, null, null, "BCA" },
                    { 3, "TU", new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5964), null, null, null, "BIT" },
                    { 4, "PU", new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5965), null, null, null, "BIT" },
                    { 5, "TU", new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5967), null, null, null, "BIM" },
                    { 6, "TU", new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5969), null, null, null, "BScIT" },
                    { 7, "PU", new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5971), null, null, null, "BScIT" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ApplicationUserId",
                table: "Students",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CollegeId",
                table: "Students",
                column: "CollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_FinAccountId",
                table: "Students",
                column: "FinAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TeamId",
                table: "Students",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TechProgramId",
                table: "Students",
                column: "TechProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TagWidget_WidgetsId",
                table: "TagWidget",
                column: "WidgetsId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_BatchId",
                table: "Teams",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "TagWidget");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Colleges");

            migrationBuilder.DropTable(
                name: "FinAccounts");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "TechPrograms");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Widgets");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Batches");
        }
    }
}
