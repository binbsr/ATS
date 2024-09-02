using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppTechnoSoft.Interns.Data.Migrations
{
    /// <inheritdoc />
    public partial class collegetrackertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28011165-162d-456f-8964-d876fd1c42f5", "2e940745-391f-4e2c-aea4-26ee766387b5" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "331fd546-8f67-42a5-a534-f8866e1f7779", "2e940745-391f-4e2c-aea4-26ee766387b5" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7aa85389-8615-453b-93df-ef50f32c6578", "2e940745-391f-4e2c-aea4-26ee766387b5" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "28011165-162d-456f-8964-d876fd1c42f5");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "331fd546-8f67-42a5-a534-f8866e1f7779");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7aa85389-8615-453b-93df-ef50f32c6578");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2e940745-391f-4e2c-aea4-26ee766387b5");

            migrationBuilder.CreateTable(
                name: "CollegeTrackers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PointOfContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CollegeId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeTrackers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CollegeTrackers_Colleges_CollegeId",
                        column: x => x.CollegeId,
                        principalTable: "Colleges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10a65312-2100-4b47-a5d6-ff9b8658329a", "10a65312-2100-4b47-a5d6-ff9b8658329a", "SuperAdmin", "SUPERADMIN" },
                    { "8744fea8-cd80-4305-a197-8c37dacedf64", "8744fea8-cd80-4305-a197-8c37dacedf64", "Admin", "ADMIN" },
                    { "d560f649-dc57-4f02-a08a-629c1ee79833", "d560f649-dc57-4f02-a08a-629c1ee79833", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a88429f4-8a9f-4ff7-ab4f-28bfaf05a9aa", 0, "2770abe8-50ed-4f24-a737-c7fe26c19f7f", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEMCOoaAi0AxiRVFbKcxoIdh9XU8bdEaet28SOlaSdiHRE7j4KnU4vpM/Tdlg3Fqc5Q==", null, false, "1c1615c6-09d2-4cfa-8328-42a1c2a72609", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 8, 31, 15, 58, 41, 670, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 8, 31, 15, 58, 41, 670, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 8, 31, 15, 58, 41, 670, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 8, 31, 15, 58, 41, 670, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 8, 31, 15, 58, 41, 670, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 8, 31, 15, 58, 41, 670, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 8, 31, 15, 58, 41, 670, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "10a65312-2100-4b47-a5d6-ff9b8658329a", "a88429f4-8a9f-4ff7-ab4f-28bfaf05a9aa" },
                    { "8744fea8-cd80-4305-a197-8c37dacedf64", "a88429f4-8a9f-4ff7-ab4f-28bfaf05a9aa" },
                    { "d560f649-dc57-4f02-a08a-629c1ee79833", "a88429f4-8a9f-4ff7-ab4f-28bfaf05a9aa" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CollegeTrackers_CollegeId",
                table: "CollegeTrackers",
                column: "CollegeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollegeTrackers");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "10a65312-2100-4b47-a5d6-ff9b8658329a", "a88429f4-8a9f-4ff7-ab4f-28bfaf05a9aa" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8744fea8-cd80-4305-a197-8c37dacedf64", "a88429f4-8a9f-4ff7-ab4f-28bfaf05a9aa" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d560f649-dc57-4f02-a08a-629c1ee79833", "a88429f4-8a9f-4ff7-ab4f-28bfaf05a9aa" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "10a65312-2100-4b47-a5d6-ff9b8658329a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8744fea8-cd80-4305-a197-8c37dacedf64");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d560f649-dc57-4f02-a08a-629c1ee79833");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a88429f4-8a9f-4ff7-ab4f-28bfaf05a9aa");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28011165-162d-456f-8964-d876fd1c42f5", "28011165-162d-456f-8964-d876fd1c42f5", "Admin", "ADMIN" },
                    { "331fd546-8f67-42a5-a534-f8866e1f7779", "331fd546-8f67-42a5-a534-f8866e1f7779", "SuperAdmin", "SUPERADMIN" },
                    { "7aa85389-8615-453b-93df-ef50f32c6578", "7aa85389-8615-453b-93df-ef50f32c6578", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2e940745-391f-4e2c-aea4-26ee766387b5", 0, "1087851e-716e-4b12-9d9b-a7d11e89fd53", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEOpq3BMnoZNO/s8/HquKeOYzuJokyXGgzrH6kxGdGm/b9WCWNZAJYyLNXH5blAxqsQ==", null, false, "9bea8133-057d-4b6f-8651-841d68aa98e8", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "28011165-162d-456f-8964-d876fd1c42f5", "2e940745-391f-4e2c-aea4-26ee766387b5" },
                    { "331fd546-8f67-42a5-a534-f8866e1f7779", "2e940745-391f-4e2c-aea4-26ee766387b5" },
                    { "7aa85389-8615-453b-93df-ef50f32c6578", "2e940745-391f-4e2c-aea4-26ee766387b5" }
                });
        }
    }
}
