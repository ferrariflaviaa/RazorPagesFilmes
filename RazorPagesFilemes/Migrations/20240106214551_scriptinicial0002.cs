using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesFilemes.Migrations
{
    /// <inheritdoc />
    public partial class scriptinicial0002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Precow",
                table: "Filme",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precow",
                table: "Filme");
        }
    }
}
