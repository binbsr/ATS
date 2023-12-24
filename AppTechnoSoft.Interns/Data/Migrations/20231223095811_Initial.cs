using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppTechnoSoft.Interns.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colleges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    PaidAmount = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TechPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Affliation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechPrograms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormSubmitted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CollegeId = table.Column<int>(type: "int", nullable: false),
                    TechProgramId = table.Column<int>(type: "int", nullable: false),
                    FinAccountId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_Students_TechPrograms_TechProgramId",
                        column: x => x.TechProgramId,
                        principalTable: "TechPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Bhadrapur, Jhapa", "Mechi Multiple Campus" },
                    { 2, "Dhankuta", "Dhankuta Multiple Campus" },
                    { 3, "Dharan", "Central Campus of Technology" },
                    { 4, "Biratnagar", "Mahendra Morang Adarsha Multiple Campus" },
                    { 5, "Rajbiraj", "Mahendra Bindeshwori Multiple Campus" },
                    { 6, "Siraha", "Surya Narayan Satya Na. Mo. Yadav Campus" },
                    { 7, "Janakpur", "Ramsorup Ramsagar Multiple Campus" },
                    { 8, "Birgunj", "Thakur Ram Multiple Campus" },
                    { 9, "Bharatpur", "Birendra Multiple Campus" },
                    { 10, "Pokhara", "Prithivi Narayan Multiple Campus" },
                    { 11, "Mahendranagar", "SidhaNath Science Campus" },
                    { 12, "Nepalgunj", "Mahendra Multiple Campus" },
                    { 13, "Butwal", "Butwal Multiple Campus" },
                    { 14, "Palpa", "Tribhuvan Multiple Campus" },
                    { 15, "Ghantaghar", "Tri-Chandra Multiple Campus" },
                    { 16, "Lainchour", "Amrit Science Campus" },
                    { 17, "Patan", "Patan Multiple Campus" },
                    { 18, "Bhaktapur", "Bhaktapur Multiple Campus" },
                    { 19, "Bagbazar", "Padma Kanya Multiple Campus" },
                    { 20, "Ghorahi, Dang", "Mahendra Multiple Campus" },
                    { 21, "Baglung", "Dhaulagiri Campus" },
                    { 22, "Gorkha", "Gorkha Campus" },
                    { 23, "Bhairahawa", "Bhairahawa Multiple Campus" },
                    { 24, "Biratnagar", "Degree Campus" }
                });

            migrationBuilder.InsertData(
                table: "TechPrograms",
                columns: new[] { "Id", "Affliation", "Name" },
                values: new object[,]
                {
                    { 1, "TU", "BCA" },
                    { 2, "PU", "BCA" },
                    { 3, "TU", "BIT" },
                    { 4, "PU", "BIT" },
                    { 5, "TU", "BIM" },
                    { 6, "TU", "BScIT" },
                    { 7, "PU", "BScIT" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_CollegeId",
                table: "Students",
                column: "CollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_FinAccountId",
                table: "Students",
                column: "FinAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TechProgramId",
                table: "Students",
                column: "TechProgramId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Colleges");

            migrationBuilder.DropTable(
                name: "FinAccounts");

            migrationBuilder.DropTable(
                name: "TechPrograms");
        }
    }
}
