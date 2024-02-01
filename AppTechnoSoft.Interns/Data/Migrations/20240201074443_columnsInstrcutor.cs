using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppTechnoSoft.Interns.Data.Migrations
{
    /// <inheritdoc />
    public partial class columnsInstrcutor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ab28733f-3261-45f3-854c-683de5504735");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d396fcee-2749-42e2-b7e8-e668a9d08bcd");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0c161ae6-7ef3-481f-a408-35518f5568ad", "07dc1470-6274-41a6-9a6b-93e953b93fd3" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0c161ae6-7ef3-481f-a408-35518f5568ad");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "07dc1470-6274-41a6-9a6b-93e953b93fd3");

            migrationBuilder.AddColumn<bool>(
                name: "Publish",
                table: "Instructors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Publish",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Instructors");

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c161ae6-7ef3-481f-a408-35518f5568ad", "0c161ae6-7ef3-481f-a408-35518f5568ad", "SuperAdmin", "SUPERADMIN" },
                    { "ab28733f-3261-45f3-854c-683de5504735", "ab28733f-3261-45f3-854c-683de5504735", "Trainee", "TRAINEE" },
                    { "d396fcee-2749-42e2-b7e8-e668a9d08bcd", "d396fcee-2749-42e2-b7e8-e668a9d08bcd", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "07dc1470-6274-41a6-9a6b-93e953b93fd3", 0, "3092fa3a-c42b-4b25-bce6-635d17acca19", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEALIEH9C8Ndsfk1Mu/eXt8AbmPqr1xq8TyMwBO7/hdkJ5Ktk379IpCq8wFfNcMvXmg==", null, false, "7a255bbc-0094-4fd4-854c-15d67f8c8ec5", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0c161ae6-7ef3-481f-a408-35518f5568ad", "07dc1470-6274-41a6-9a6b-93e953b93fd3" });
        }
    }
}
