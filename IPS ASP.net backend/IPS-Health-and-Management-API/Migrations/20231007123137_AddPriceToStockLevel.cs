using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IPS_Health_and_Management_API.Migrations
{
    /// <inheritdoc />
    public partial class AddPriceToStockLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "ProductStock",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "ProductStock");
        }
    }
}
