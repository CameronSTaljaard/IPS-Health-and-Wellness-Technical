using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IPS_Health_and_Management_API.Migrations
{
    /// <inheritdoc />
    public partial class SmallChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "CartProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9599), 79m, 7 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9678), 76m, 4 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9688), 87m, 2 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9696), 90m, 2 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9705), 72m, 4 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9714), 51m, 7 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9721), 71m, 5 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9728), 84m, 4 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9734), 75m, 2 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9747), 19m, 4 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateTaken", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9753), 1 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9760), 22m, 9 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9766), 25m, 1 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9773), 10m, 8 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9778), 24m, 8 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9785), 13m, 1 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9840), 11m, 7 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9850), 10m, 6 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9857), 51m, 4 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9866), 93m, 5 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateTaken", "Price" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9871), 78m });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateTaken", "Price" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9879), 88m });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9884), 86m, 5 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9891), 63m, 6 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9900), 12m, 3 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9908), 20m, 1 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9913), 26m, 9 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9920), 26m, 6 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9926), 22m, 9 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 53, 49, 119, DateTimeKind.Utc).AddTicks(9933), 20m, 4 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "WK981Dx/aDOvEUMSVAhE+lCPcTlulU0wbwkA9jY/W/T7fst+");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "CartProduct");

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
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5748), 71m, 5 });

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
                columns: new[] { "DateTaken", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5769), 3 });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5775), 11m, 2 });

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
                columns: new[] { "DateTaken", "Price" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5869), 76m });

            migrationBuilder.UpdateData(
                table: "ProductStock",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateTaken", "Price" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5874), 95m });

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
                columns: new[] { "DateTaken", "Price", "StockLevel" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 45, 56, 122, DateTimeKind.Utc).AddTicks(5924), 11m, 7 });

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
    }
}
