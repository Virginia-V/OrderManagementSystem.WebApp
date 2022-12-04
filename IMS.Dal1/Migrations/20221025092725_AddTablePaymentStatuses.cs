using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OMS.Dal.Migrations
{
    public partial class AddTablePaymentStatuses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaidDate",
                table: "Invoices");

            migrationBuilder.AddColumn<int>(
                name: "PaymentStatusId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PaymentStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStatuses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PaymentStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[] { 1, "Paid" });

            migrationBuilder.InsertData(
                table: "PaymentStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[] { 2, "UnPaid" });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_PaymentStatusId",
                table: "Invoices",
                column: "PaymentStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_PaymentStatuses_PaymentStatusId",
                table: "Invoices",
                column: "PaymentStatusId",
                principalTable: "PaymentStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_PaymentStatuses_PaymentStatusId",
                table: "Invoices");

            migrationBuilder.DropTable(
                name: "PaymentStatuses");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_PaymentStatusId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "PaymentStatusId",
                table: "Invoices");

            migrationBuilder.AddColumn<DateTime>(
                name: "PaidDate",
                table: "Invoices",
                type: "datetime2",
                nullable: true);
        }
    }
}
