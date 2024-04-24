using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yoko.Migrations
{
    /// <inheritdoc />
    public partial class AddedReservationToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YoServices_YoOrders_YoOrderId",
                table: "YoServices");

            migrationBuilder.DropIndex(
                name: "IX_YoServices_YoOrderId",
                table: "YoServices");

            migrationBuilder.DropColumn(
                name: "YoOrderId",
                table: "YoServices");

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "YoOrders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_YoOrders_ReservationId",
                table: "YoOrders",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_YoOrders_YoReservations_ReservationId",
                table: "YoOrders",
                column: "ReservationId",
                principalTable: "YoReservations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YoOrders_YoReservations_ReservationId",
                table: "YoOrders");

            migrationBuilder.DropIndex(
                name: "IX_YoOrders_ReservationId",
                table: "YoOrders");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "YoOrders");

            migrationBuilder.AddColumn<int>(
                name: "YoOrderId",
                table: "YoServices",
                type: "int",
                nullable: true);

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
    }
}
