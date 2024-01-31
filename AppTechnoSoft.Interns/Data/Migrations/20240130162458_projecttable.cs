using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppTechnoSoft.Interns.Data.Migrations
{
    /// <inheritdoc />
    public partial class projecttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ce0d64ac-354d-4ade-8ed8-991be51234eb");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f5230dfc-941b-4e51-9ae2-c99e09c3a8c9");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ce2e0bd6-7aac-42ff-8cee-5d6e95d556dc", "02610d47-09c5-44db-9272-ee96e85c41e7" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ce2e0bd6-7aac-42ff-8cee-5d6e95d556dc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "02610d47-09c5-44db-9272-ee96e85c41e7");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ProjectDetails",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "ProjectTitle",
                table: "Teams",
                newName: "Avatar");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requirements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RepoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoardUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "295ea465-4103-4e69-a64e-32c5e673f029", "295ea465-4103-4e69-a64e-32c5e673f029", "SuperAdmin", "SUPERADMIN" },
                    { "6171bf73-b50c-4a8b-b58d-d75417553a33", "6171bf73-b50c-4a8b-b58d-d75417553a33", "Trainee", "TRAINEE" },
                    { "f142d0a0-0b94-40fe-9a90-f2c370b51d1a", "f142d0a0-0b94-40fe-9a90-f2c370b51d1a", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f571c1cc-fa5d-4bcb-a705-7b10021f7655", 0, "d62e8d24-9f0c-45d7-909c-19169c0902da", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEPqmEPvZ+93OXDf4o9IDNHFdroK9xlwBnIiRX81/D4WwZSvlFSD9lPQkhqr6g+NlVw==", null, false, "e647ab4b-5bb1-4cb6-8306-a304da2e92d5", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 1, 30, 22, 9, 57, 815, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "295ea465-4103-4e69-a64e-32c5e673f029", "f571c1cc-fa5d-4bcb-a705-7b10021f7655" });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ProjectId",
                table: "Teams",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Projects_ProjectId",
                table: "Teams",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Projects_ProjectId",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Teams_ProjectId",
                table: "Teams");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6171bf73-b50c-4a8b-b58d-d75417553a33");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f142d0a0-0b94-40fe-9a90-f2c370b51d1a");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "295ea465-4103-4e69-a64e-32c5e673f029", "f571c1cc-fa5d-4bcb-a705-7b10021f7655" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "295ea465-4103-4e69-a64e-32c5e673f029");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f571c1cc-fa5d-4bcb-a705-7b10021f7655");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "Avatar",
                table: "Teams",
                newName: "ProjectTitle");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectDetails",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ce0d64ac-354d-4ade-8ed8-991be51234eb", "ce0d64ac-354d-4ade-8ed8-991be51234eb", "Admin", "ADMIN" },
                    { "ce2e0bd6-7aac-42ff-8cee-5d6e95d556dc", "ce2e0bd6-7aac-42ff-8cee-5d6e95d556dc", "SuperAdmin", "SUPERADMIN" },
                    { "f5230dfc-941b-4e51-9ae2-c99e09c3a8c9", "f5230dfc-941b-4e51-9ae2-c99e09c3a8c9", "Trainee", "TRAINEE" }
                });

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "02610d47-09c5-44db-9272-ee96e85c41e7", 0, "896e5218-dcc0-4031-9603-9405e2ba7afa", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEEDgGdAmsEJtlmkEvBs5o39iCuab4wnzBhCwotfffet9hwfU9P5rGvn4Cs+B9IB+FQ==", null, false, "6a0f399c-1e85-49f9-9afc-728f142dbc1d", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 1, 23, 21, 26, 33, 454, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ce2e0bd6-7aac-42ff-8cee-5d6e95d556dc", "02610d47-09c5-44db-9272-ee96e85c41e7" });
        }
    }
}
