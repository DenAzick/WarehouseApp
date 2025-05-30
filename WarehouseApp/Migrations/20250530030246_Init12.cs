using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehouseApp.Migrations
{
    /// <inheritdoc />
    public partial class Init12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Warehouses_WarehouseId",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "WarehouseId",
                table: "Categories",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Warehouses_WarehouseId",
                table: "Categories",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Warehouses_WarehouseId",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "WarehouseId",
                table: "Categories",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Warehouses_WarehouseId",
                table: "Categories",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id");
        }
    }
}
