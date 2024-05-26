using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPage.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "MyProduct",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MyProduct",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "MyProduct");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "MyProduct");
        }
    }
}
