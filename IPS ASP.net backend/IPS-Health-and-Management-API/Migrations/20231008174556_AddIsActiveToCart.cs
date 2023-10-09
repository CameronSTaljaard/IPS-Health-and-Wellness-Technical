using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IPS_Health_and_Management_API.Migrations
{
    /// <inheritdoc />
    public partial class AddIsActiveToCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Cart",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5621), 62m, 5 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5685), 96m, 3 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5707), 73m, 9 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5712), 93m, 6 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5721), 93m, 2 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5727), 99m, 9 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5735), 87m, 1 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5740), 76m, 8 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateTaken", "Price" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5748), 71m });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5760), 13m, 7 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5769), 14m, 3 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateTaken", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5775), 2 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5782), 26m, 6 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5787), 27m, 7 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5795), 21m, 1 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5800), 19m, 2 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5839), 23m, 2 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5846), 20m, 3 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5855), 69m, 8 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5862), 54m, 2 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5869), 76m, 1 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5874), 95m, 3 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5881), 76m, 8 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5886), 70m, 2 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5898), 10m, 1 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5904), 29m, 6 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5912), 15m, 6 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5917), 18m, 1 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateTaken", "Price" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5924), 11m });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5929), 29m, 7 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "0ZXZeT/GTOsNzE75fiEW2cFgsMpRLiJvdoCQL7VEw0BFtEtO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Cart");

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3028), 52m, 3 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3150), 76m, 4 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3155), 52m, 4 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3163), 51m, 5 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3170), 63m, 7 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3178), 77m, 2 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3184), 60m, 9 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3191), 59m, 9 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateTaken", "Price" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3197), 91m });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3209), 18m, 2 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3216), 13m, 7 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateTaken", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3223), 9 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3229), 21m, 9 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3236), 16m, 4 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3242), 24m, 2 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3249), 23m, 5 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3291), 21m, 6 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3302), 12m, 5 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3309), 78m, 9 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3317), 57m, 8 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3323), 56m, 3 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3330), 75m, 6 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3335), 83m, 9 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3342), 50m, 3 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3352), 18m, 6 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3360), 21m, 1 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3366), 21m, 3 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3373), 19m, 5 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateTaken", "Price" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3379), 21m });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 7, 13, 45, 1, 75, DateTimeKind.Utc).AddTicks(3386), 13m, 2 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "czh8CcRplIgmKlF1A49lwyFqxLbYfm8p7Ma19kBZOxuOHjJV");
        }
    }
}
