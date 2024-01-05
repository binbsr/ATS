using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppTechnoSoft.Interns.Data.Migrations
{
    /// <inheritdoc />
    public partial class AuditColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Widgets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Widgets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Widgets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "Widgets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TechPrograms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "TechPrograms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "TechPrograms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "TechPrograms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Tags",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Tags",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Students",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Students",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "FinAccounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "FinAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "FinAccounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "FinAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Colleges",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Colleges",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Colleges",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "Colleges",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Students_TeamId",
                table: "Students",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Team_TeamId",
                table: "Students",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Team_TeamId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Students_TeamId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Widgets");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Widgets");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Widgets");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "Widgets");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TechPrograms");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TechPrograms");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "TechPrograms");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "TechPrograms");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "FinAccounts");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "FinAccounts");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "FinAccounts");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "FinAccounts");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Colleges");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Colleges");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Colleges");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "Colleges");
        }
    }
}
