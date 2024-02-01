using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppTechnoSoft.Interns.Data.Migrations
{
    /// <inheritdoc />
    public partial class addcolumntostudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8365d9c3-cbaf-466d-9878-61a30807ed18");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e866ced8-0267-426f-9e73-329b85b59cf8");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c37f3486-8b30-4e7c-baf8-d279fcd0492f", "5af9e0cf-104d-4d35-9b01-844b83e3cc32" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c37f3486-8b30-4e7c-baf8-d279fcd0492f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5af9e0cf-104d-4d35-9b01-844b83e3cc32");

            migrationBuilder.AddColumn<int>(
                name: "GeneralProgramming",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "490fd83a-446c-46a1-92b5-8ff7e0d3c3e0", "490fd83a-446c-46a1-92b5-8ff7e0d3c3e0", "SuperAdmin", "SUPERADMIN" },
                    { "c3c5fb0a-ddb0-4511-8bb5-d8895f9cf88b", "c3c5fb0a-ddb0-4511-8bb5-d8895f9cf88b", "Trainee", "TRAINEE" },
                    { "e544108f-cef5-4d55-b825-610f89a917e5", "e544108f-cef5-4d55-b825-610f89a917e5", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6f3b973d-fe2b-47c4-96a9-a36d410757df", 0, "59aa2257-5f00-4e34-81c3-8d97fde7dc53", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEC6StSSZsde2JxgIYAssvRzcbr4aJygVrBPYOca/KpxJS1cWJYDtu47ANn4UF2MusA==", null, false, "93ab1764-79a0-4d60-b1ac-14c76c7cdc4a", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 1, 18, 27, 35, 845, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "490fd83a-446c-46a1-92b5-8ff7e0d3c3e0", "6f3b973d-fe2b-47c4-96a9-a36d410757df" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c3c5fb0a-ddb0-4511-8bb5-d8895f9cf88b");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e544108f-cef5-4d55-b825-610f89a917e5");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "490fd83a-446c-46a1-92b5-8ff7e0d3c3e0", "6f3b973d-fe2b-47c4-96a9-a36d410757df" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "490fd83a-446c-46a1-92b5-8ff7e0d3c3e0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6f3b973d-fe2b-47c4-96a9-a36d410757df");

            migrationBuilder.DropColumn(
                name: "GeneralProgramming",
                table: "Students");

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8365d9c3-cbaf-466d-9878-61a30807ed18", "8365d9c3-cbaf-466d-9878-61a30807ed18", "Admin", "ADMIN" },
                    { "c37f3486-8b30-4e7c-baf8-d279fcd0492f", "c37f3486-8b30-4e7c-baf8-d279fcd0492f", "SuperAdmin", "SUPERADMIN" },
                    { "e866ced8-0267-426f-9e73-329b85b59cf8", "e866ced8-0267-426f-9e73-329b85b59cf8", "Trainee", "TRAINEE" }
                });

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5af9e0cf-104d-4d35-9b01-844b83e3cc32", 0, "734b0658-4eb4-4342-b263-92af088b880b", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEKh5jT1DkwkWV4ok264fFudO9FouFp5+rWsTYlENEPkPjPpPDqBpDMKKz9cP31l+/Q==", null, false, "a7334c46-1e4c-41ea-8799-4f29cb2a6b9a", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 1, 13, 29, 42, 978, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c37f3486-8b30-4e7c-baf8-d279fcd0492f", "5af9e0cf-104d-4d35-9b01-844b83e3cc32" });
        }
    }
}
