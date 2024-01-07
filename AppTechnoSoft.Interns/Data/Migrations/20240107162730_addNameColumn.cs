using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppTechnoSoft.Interns.Data.Migrations
{
    /// <inheritdoc />
    public partial class addNameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Batches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 1, 7, 22, 12, 29, 792, DateTimeKind.Local).AddTicks(9440));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Batches");

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 1, 7, 16, 1, 35, 279, DateTimeKind.Local).AddTicks(5971));
        }
    }
}
