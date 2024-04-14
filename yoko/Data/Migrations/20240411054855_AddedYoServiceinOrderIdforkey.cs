using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yoko.Migrations
{
    /// <inheritdoc />
    public partial class AddedYoServiceinOrderIdforkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_YoServiceinOrders",
                table: "YoServiceinOrders");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "YoServiceinOrders",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_YoServiceinOrders",
                table: "YoServiceinOrders",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_YoServiceinOrders_ServiceId",
                table: "YoServiceinOrders",
                column: "ServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_YoServiceinOrders",
                table: "YoServiceinOrders");

            migrationBuilder.DropIndex(
                name: "IX_YoServiceinOrders_ServiceId",
                table: "YoServiceinOrders");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "YoServiceinOrders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_YoServiceinOrders",
                table: "YoServiceinOrders",
                column: "ServiceId");
        }
    }
}
