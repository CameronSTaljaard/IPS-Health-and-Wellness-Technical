using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IPS_Health_and_Management_API.Migrations
{
    /// <inheritdoc />
    public partial class AddImageToCatergories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageString",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageString",
                table: "Category");
        }
    }
}
