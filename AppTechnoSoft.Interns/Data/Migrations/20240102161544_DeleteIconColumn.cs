using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppTechnoSoft.Interns.Data.Migrations
{
    /// <inheritdoc />
    public partial class DeleteIconColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Widgets");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Widgets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
