using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yoko.Migrations
{
    /// <inheritdoc />
    public partial class AddedYoOrderwithoutForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YoOrderId",
                table: "YoServices",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "YoOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YoOrders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_YoServices_YoOrderId",
                table: "YoServices",
                column: "YoOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_YoServices_YoOrders_YoOrderId",
                table: "YoServices",
                column: "YoOrderId",
                principalTable: "YoOrders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YoServices_YoOrders_YoOrderId",
                table: "YoServices");

            migrationBuilder.DropTable(
                name: "YoOrders");

            migrationBuilder.DropIndex(
                name: "IX_YoServices_YoOrderId",
                table: "YoServices");

            migrationBuilder.DropColumn(
                name: "YoOrderId",
                table: "YoServices");
        }
    }
}
