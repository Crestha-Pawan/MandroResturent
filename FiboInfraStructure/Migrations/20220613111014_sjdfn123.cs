using Microsoft.EntityFrameworkCore.Migrations;

namespace FiboInfraStructure.Migrations
{
    public partial class sjdfn123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BillingStatus",
                table: "BillingStatus");

            migrationBuilder.RenameTable(
                name: "BillingStatus",
                newName: "BillingStatuss");

            migrationBuilder.AddColumn<decimal>(
                name: "ServiceCharge",
                table: "Billings",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<long>(
                name: "ServiceChargeId",
                table: "Billings",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TaxAmount",
                table: "Billings",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<long>(
                name: "TaxId",
                table: "Billings",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillingStatuss",
                table: "BillingStatuss",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BillingStatuss",
                table: "BillingStatuss");

            migrationBuilder.DropColumn(
                name: "ServiceCharge",
                table: "Billings");

            migrationBuilder.DropColumn(
                name: "ServiceChargeId",
                table: "Billings");

            migrationBuilder.DropColumn(
                name: "TaxAmount",
                table: "Billings");

            migrationBuilder.DropColumn(
                name: "TaxId",
                table: "Billings");

            migrationBuilder.RenameTable(
                name: "BillingStatuss",
                newName: "BillingStatus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillingStatus",
                table: "BillingStatus",
                column: "Id");
        }
    }
}
