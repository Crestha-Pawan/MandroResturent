using Microsoft.EntityFrameworkCore.Migrations;

namespace FiboInfraStructure.Migrations
{
    public partial class jenfk123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Kot_Bot",
                table: "Billings",
                newName: "KotBotBy");

            migrationBuilder.AddColumn<string>(
                name: "Order",
                table: "BillingInfo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "BillingInfo");

            migrationBuilder.RenameColumn(
                name: "KotBotBy",
                table: "Billings",
                newName: "Kot_Bot");
        }
    }
}
