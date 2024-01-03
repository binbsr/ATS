using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppTechnoSoft.Interns.Data.Migrations
{
    /// <inheritdoc />
    public partial class DeleteTypeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Widgets");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Widgets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
