using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RetroDL.Migrations
{
    public partial class SixthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Orders_OrdersOrderID",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_OrdersOrderID",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "OrdersOrderID",
                table: "CartItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrdersOrderID",
                table: "CartItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_OrdersOrderID",
                table: "CartItems",
                column: "OrdersOrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Orders_OrdersOrderID",
                table: "CartItems",
                column: "OrdersOrderID",
                principalTable: "Orders",
                principalColumn: "OrderID");
        }
    }
}
