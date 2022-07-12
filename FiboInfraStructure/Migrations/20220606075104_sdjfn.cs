using Microsoft.EntityFrameworkCore.Migrations;

namespace FiboInfraStructure.Migrations
{
    public partial class sdjfn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
