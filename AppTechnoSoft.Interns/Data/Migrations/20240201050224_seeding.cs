using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppTechnoSoft.Interns.Data.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstructorTag_Instructor_InstructorId",
                table: "InstructorTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "Instructors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "Id", "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy", "Location", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4543), null, null, null, "Bhadrapur, Jhapa", "Mechi Multiple Campus" },
                    { 2, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4563), null, null, null, "Dhankuta", "Dhankuta Multiple Campus" },
                    { 3, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4565), null, null, null, "Dharan", "Central Campus of Technology" },
                    { 4, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4566), null, null, null, "Biratnagar", "Mahendra Morang Adarsha Multiple Campus" },
                    { 5, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4567), null, null, null, "Rajbiraj", "Mahendra Bindeshwori Multiple Campus" },
                    { 6, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4568), null, null, null, "Siraha", "Surya Narayan Satya Na. Mo. Yadav Campus" },
                    { 7, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4569), null, null, null, "Janakpur", "Ramsorup Ramsagar Multiple Campus" },
                    { 8, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4570), null, null, null, "Birgunj", "Thakur Ram Multiple Campus" },
                    { 9, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4571), null, null, null, "Bharatpur", "Birendra Multiple Campus" },
                    { 10, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4572), null, null, null, "Pokhara", "Prithivi Narayan Multiple Campus" },
                    { 11, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4573), null, null, null, "Mahendranagar", "SidhaNath Science Campus" },
                    { 12, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4574), null, null, null, "Nepalgunj", "Mahendra Multiple Campus" },
                    { 13, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4575), null, null, null, "Butwal", "Butwal Multiple Campus" },
                    { 14, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4576), null, null, null, "Palpa", "Tribhuvan Multiple Campus" },
                    { 15, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4577), null, null, null, "Ghantaghar", "Tri-Chandra Multiple Campus" },
                    { 16, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4577), null, null, null, "Lainchour", "Amrit Science Campus" },
                    { 17, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4578), null, null, null, "Patan", "Patan Multiple Campus" },
                    { 18, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4579), null, null, null, "Bhaktapur", "Bhaktapur Multiple Campus" },
                    { 19, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4580), null, null, null, "Bagbazar", "Padma Kanya Multiple Campus" },
                    { 20, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4581), null, null, null, "Ghorahi, Dang", "Mahendra Multiple Campus" },
                    { 21, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4583), null, null, null, "Baglung", "Dhaulagiri Campus" },
                    { 22, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4583), null, null, null, "Gorkha", "Gorkha Campus" },
                    { 23, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4584), null, null, null, "Bhairahawa", "Bhairahawa Multiple Campus" },
                    { 24, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4585), null, null, null, "Biratnagar", "Degree Campus" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c161ae6-7ef3-481f-a408-35518f5568ad", "0c161ae6-7ef3-481f-a408-35518f5568ad", "SuperAdmin", "SUPERADMIN" },
                    { "ab28733f-3261-45f3-854c-683de5504735", "ab28733f-3261-45f3-854c-683de5504735", "Trainee", "TRAINEE" },
                    { "d396fcee-2749-42e2-b7e8-e668a9d08bcd", "d396fcee-2749-42e2-b7e8-e668a9d08bcd", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "TechPrograms",
                columns: new[] { "Id", "Affliation", "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 1, "TU", new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4727), null, null, null, "BCA" },
                    { 2, "PU", new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4729), null, null, null, "BCA" },
                    { 3, "TU", new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4731), null, null, null, "BIT" },
                    { 4, "PU", new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4732), null, null, null, "BIT" },
                    { 5, "TU", new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4732), null, null, null, "BIM" },
                    { 6, "TU", new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4733), null, null, null, "BScIT" },
                    { 7, "PU", new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4734), null, null, null, "BScIT" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "07dc1470-6274-41a6-9a6b-93e953b93fd3", 0, "3092fa3a-c42b-4b25-bce6-635d17acca19", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEALIEH9C8Ndsfk1Mu/eXt8AbmPqr1xq8TyMwBO7/hdkJ5Ktk379IpCq8wFfNcMvXmg==", null, false, "7a255bbc-0094-4fd4-854c-15d67f8c8ec5", false, "rawal.bishnu@live.com" });

            migrationBuilder.InsertData(
                table: "Widgets",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "HtmlContent", "LastUpdated", "LastUpdatedBy", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4764), "Seed", "An display item in home page", "Welcome to AppTechnoSoft! An initiative for students and freshers.", null, null, "CarouselItem" },
                    { 2, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4767), "Seed", "An display item in home page", "Bridging the gap between academia and industry!", null, null, "CarouselItem" },
                    { 3, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4769), "Seed", "An display item in home page", "We guide you on software R&D and SDLC to kickstart your career!", null, null, "CarouselItem" },
                    { 4, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4772), "Seed", "An display item in home page", "Replacement Opportunities!", null, null, "CarouselItem" },
                    { 5, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4773), "Seed", "An display item in home page", "From basics to professional touches!", null, null, "CarouselItem" },
                    { 6, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4775), "Seed", "GIT and GitHub Essentials", "todo", null, null, "Module" },
                    { 7, new DateTime(2024, 2, 1, 10, 47, 23, 574, DateTimeKind.Local).AddTicks(4777), "Seed", "Training + Internship Combo", "todo", null, null, "HomeIntro" }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0c161ae6-7ef3-481f-a408-35518f5568ad", "07dc1470-6274-41a6-9a6b-93e953b93fd3" });

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorTag_Instructors_InstructorId",
                table: "InstructorTag",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstructorTag_Instructors_InstructorId",
                table: "InstructorTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

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
                keyValue: "ab28733f-3261-45f3-854c-683de5504735");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d396fcee-2749-42e2-b7e8-e668a9d08bcd");

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
                keyValues: new object[] { "0c161ae6-7ef3-481f-a408-35518f5568ad", "07dc1470-6274-41a6-9a6b-93e953b93fd3" });

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
                keyValue: "0c161ae6-7ef3-481f-a408-35518f5568ad");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "07dc1470-6274-41a6-9a6b-93e953b93fd3");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorTag_Instructor_InstructorId",
                table: "InstructorTag",
                column: "InstructorId",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
