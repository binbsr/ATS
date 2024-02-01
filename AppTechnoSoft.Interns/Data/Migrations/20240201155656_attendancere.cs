using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppTechnoSoft.Interns.Data.Migrations
{
    /// <inheritdoc />
    public partial class attendancere : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    PunchIn = table.Column<TimeOnly>(type: "time", nullable: true),
                    PunchOut = table.Column<TimeOnly>(type: "time", nullable: true),
                    WorkLog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4917ba55-af39-40a3-88b4-471a13ab679c", "4917ba55-af39-40a3-88b4-471a13ab679c", "Trainee", "TRAINEE" },
                    { "5a24c9cb-4ff7-4ad4-b2e1-b5aa351db4ee", "5a24c9cb-4ff7-4ad4-b2e1-b5aa351db4ee", "Admin", "ADMIN" },
                    { "f8baa4f4-be74-4525-b67c-ea2eb15fd3c7", "f8baa4f4-be74-4525-b67c-ea2eb15fd3c7", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5c0ec5ac-a549-4e0a-9167-e5eddec34667", 0, "7bc7d4ad-094d-4fc4-a9ec-7353b740179a", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEIDw5oHL8/iKJOCwOK4ItMVdd/HBPl56G8/divGzzZEX8FYjX/z3fcWFOPUyOwbPiw==", null, false, "8e73d296-c25e-42e9-8373-42adb679e287", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 1, 21, 41, 55, 644, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f8baa4f4-be74-4525-b67c-ea2eb15fd3c7", "5c0ec5ac-a549-4e0a-9167-e5eddec34667" });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendances",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4917ba55-af39-40a3-88b4-471a13ab679c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5a24c9cb-4ff7-4ad4-b2e1-b5aa351db4ee");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f8baa4f4-be74-4525-b67c-ea2eb15fd3c7", "5c0ec5ac-a549-4e0a-9167-e5eddec34667" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f8baa4f4-be74-4525-b67c-ea2eb15fd3c7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5c0ec5ac-a549-4e0a-9167-e5eddec34667");

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
    }
}
