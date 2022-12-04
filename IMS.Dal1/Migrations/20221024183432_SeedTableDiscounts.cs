using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OMS.Dal.Migrations
{
    public partial class SeedTableDiscounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "DiscountType", "DiscountValue" },
                values: new object[] { 1, "Discount 10+boxes", 0.10m });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "DiscountType", "DiscountValue" },
                values: new object[] { 2, "Discount Starter Kit E-DaVinci", 0.20m });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "DiscountType", "DiscountValue" },
                values: new object[] { 3, "Discount Starter Kit E-Leo", 0.20m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
