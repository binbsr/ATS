using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppTechnoSoft.Interns.Data.Migrations
{
    /// <inheritdoc />
    public partial class addinstructor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6171bf73-b50c-4a8b-b58d-d75417553a33");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f142d0a0-0b94-40fe-9a90-f2c370b51d1a");

            migrationBuilder.DeleteData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "295ea465-4103-4e69-a64e-32c5e673f029", "f571c1cc-fa5d-4bcb-a705-7b10021f7655" });

            migrationBuilder.DeleteData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "295ea465-4103-4e69-a64e-32c5e673f029");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f571c1cc-fa5d-4bcb-a705-7b10021f7655");

            migrationBuilder.AlterColumn<string>(
                name: "RepoUrl",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BoardUrl",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Instrcutor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrcutor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstrcutorTag",
                columns: table => new
                {
                    InstrcutorId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstrcutorTag", x => new { x.InstrcutorId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_InstrcutorTag_Instrcutor_InstrcutorId",
                        column: x => x.InstrcutorId,
                        principalTable: "Instrcutor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstrcutorTag_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InstrcutorTag_TagsId",
                table: "InstrcutorTag",
                column: "TagsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstrcutorTag");

            migrationBuilder.DropTable(
                name: "Instrcutor");

            migrationBuilder.AlterColumn<string>(
                name: "RepoUrl",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BoardUrl",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "Id", "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy", "Location", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8416), null, null, null, "Bhadrapur, Jhapa", "Mechi Multiple Campus" },
                    { 2, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8433), null, null, null, "Dhankuta", "Dhankuta Multiple Campus" },
                    { 3, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8434), null, null, null, "Dharan", "Central Campus of Technology" },
                    { 4, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8435), null, null, null, "Biratnagar", "Mahendra Morang Adarsha Multiple Campus" },
                    { 5, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8436), null, null, null, "Rajbiraj", "Mahendra Bindeshwori Multiple Campus" },
                    { 6, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8437), null, null, null, "Siraha", "Surya Narayan Satya Na. Mo. Yadav Campus" },
                    { 7, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8438), null, null, null, "Janakpur", "Ramsorup Ramsagar Multiple Campus" },
                    { 8, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8439), null, null, null, "Birgunj", "Thakur Ram Multiple Campus" },
                    { 9, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8440), null, null, null, "Bharatpur", "Birendra Multiple Campus" },
                    { 10, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8441), null, null, null, "Pokhara", "Prithivi Narayan Multiple Campus" },
                    { 11, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8442), null, null, null, "Mahendranagar", "SidhaNath Science Campus" },
                    { 12, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8443), null, null, null, "Nepalgunj", "Mahendra Multiple Campus" },
                    { 13, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8444), null, null, null, "Butwal", "Butwal Multiple Campus" },
                    { 14, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8445), null, null, null, "Palpa", "Tribhuvan Multiple Campus" },
                    { 15, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8446), null, null, null, "Ghantaghar", "Tri-Chandra Multiple Campus" },
                    { 16, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8447), null, null, null, "Lainchour", "Amrit Science Campus" },
                    { 17, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8448), null, null, null, "Patan", "Patan Multiple Campus" },
                    { 18, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8448), null, null, null, "Bhaktapur", "Bhaktapur Multiple Campus" },
                    { 19, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8449), null, null, null, "Bagbazar", "Padma Kanya Multiple Campus" },
                    { 20, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8450), null, null, null, "Ghorahi, Dang", "Mahendra Multiple Campus" },
                    { 21, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8451), null, null, null, "Baglung", "Dhaulagiri Campus" },
                    { 22, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8452), null, null, null, "Gorkha", "Gorkha Campus" },
                    { 23, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8453), null, null, null, "Bhairahawa", "Bhairahawa Multiple Campus" },
                    { 24, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8453), null, null, null, "Biratnagar", "Degree Campus" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "295ea465-4103-4e69-a64e-32c5e673f029", "295ea465-4103-4e69-a64e-32c5e673f029", "SuperAdmin", "SUPERADMIN" },
                    { "6171bf73-b50c-4a8b-b58d-d75417553a33", "6171bf73-b50c-4a8b-b58d-d75417553a33", "Trainee", "TRAINEE" },
                    { "f142d0a0-0b94-40fe-9a90-f2c370b51d1a", "f142d0a0-0b94-40fe-9a90-f2c370b51d1a", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "TechPrograms",
                columns: new[] { "Id", "Affliation", "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 1, "TU", new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8609), null, null, null, "BCA" },
                    { 2, "PU", new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8611), null, null, null, "BCA" },
                    { 3, "TU", new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8613), null, null, null, "BIT" },
                    { 4, "PU", new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8613), null, null, null, "BIT" },
                    { 5, "TU", new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8614), null, null, null, "BIM" },
                    { 6, "TU", new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8615), null, null, null, "BScIT" },
                    { 7, "PU", new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8616), null, null, null, "BScIT" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f571c1cc-fa5d-4bcb-a705-7b10021f7655", 0, "d62e8d24-9f0c-45d7-909c-19169c0902da", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEPqmEPvZ+93OXDf4o9IDNHFdroK9xlwBnIiRX81/D4WwZSvlFSD9lPQkhqr6g+NlVw==", null, false, "e647ab4b-5bb1-4cb6-8306-a304da2e92d5", false, "rawal.bishnu@live.com" });

            migrationBuilder.InsertData(
                table: "Widgets",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "HtmlContent", "LastUpdated", "LastUpdatedBy", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8670), "Seed", "An display item in home page", "Welcome to AppTechnoSoft! An initiative for students and freshers.", null, null, "CarouselItem" },
                    { 2, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8672), "Seed", "An display item in home page", "Bridging the gap between academia and industry!", null, null, "CarouselItem" },
                    { 3, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8674), "Seed", "An display item in home page", "We guide you on software R&D and SDLC to kickstart your career!", null, null, "CarouselItem" },
                    { 4, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8676), "Seed", "An display item in home page", "Replacement Opportunities!", null, null, "CarouselItem" },
                    { 5, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8678), "Seed", "An display item in home page", "From basics to professional touches!", null, null, "CarouselItem" },
                    { 6, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8680), "Seed", "GIT and GitHub Essentials", "todo", null, null, "Module" },
                    { 7, new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8682), "Seed", "Training + Internship Combo", "todo", null, null, "HomeIntro" }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "295ea465-4103-4e69-a64e-32c5e673f029", "f571c1cc-fa5d-4bcb-a705-7b10021f7655" });
        }
    }
}
