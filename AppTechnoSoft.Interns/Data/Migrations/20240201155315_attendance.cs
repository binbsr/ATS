using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppTechnoSoft.Interns.Data.Migrations
{
    /// <inheritdoc />
    public partial class Attendance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6b0512bf-e8bf-453f-b7af-500e9e954af8", "6b0512bf-e8bf-453f-b7af-500e9e954af8", "Admin", "ADMIN" },
                    { "985381b9-a0c8-4f27-be80-ffc37ca80fa8", "985381b9-a0c8-4f27-be80-ffc37ca80fa8", "SuperAdmin", "SUPERADMIN" },
                    { "bc64625c-e34e-4c69-a5ed-bf653aee2fba", "bc64625c-e34e-4c69-a5ed-bf653aee2fba", "Trainee", "TRAINEE" }
                });

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3b3b64c9-0668-42eb-9189-2b6000816ede", 0, "d9bfb96e-4ad3-44eb-a1ae-2b3c9d5df59d", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEKiP2RNTZS7/RBA2vqIUYL2ZVAXAvj1FxmWTD3IKGgZ1HRJMLPuAi7l2faTspuWM/Q==", null, false, "e2847b76-e871-41c3-a52e-6ebf18294052", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 38, 14, 397, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "985381b9-a0c8-4f27-be80-ffc37ca80fa8", "3b3b64c9-0668-42eb-9189-2b6000816ede" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6b0512bf-e8bf-453f-b7af-500e9e954af8");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "bc64625c-e34e-4c69-a5ed-bf653aee2fba");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "985381b9-a0c8-4f27-be80-ffc37ca80fa8", "3b3b64c9-0668-42eb-9189-2b6000816ede" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "985381b9-a0c8-4f27-be80-ffc37ca80fa8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3b3b64c9-0668-42eb-9189-2b6000816ede");

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
    }
}
