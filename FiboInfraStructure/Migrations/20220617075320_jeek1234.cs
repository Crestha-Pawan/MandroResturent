using Microsoft.EntityFrameworkCore.Migrations;

namespace FiboInfraStructure.Migrations
{
    public partial class jeek1234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BillingStatuss",
                table: "BillingStatuss");

            migrationBuilder.RenameTable(
                name: "BillingStatuss",
                newName: "BillingStatus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillingStatus",
                table: "BillingStatus",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BillingStatus",
                table: "BillingStatus");

            migrationBuilder.RenameTable(
                name: "BillingStatus",
                newName: "BillingStatuss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillingStatuss",
                table: "BillingStatuss",
                column: "Id");
        }
    }
}
