using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yoko.Migrations
{
    /// <inheritdoc />
    public partial class AddedYoOrderAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "YoOrders",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NotificationId",
                table: "YoOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "YoOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_YoOrders_EmployeeId",
                table: "YoOrders",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_YoOrders_NotificationId",
                table: "YoOrders",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_YoOrders_ReservationId",
                table: "YoOrders",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_YoOrders_AspNetUsers_EmployeeId",
                table: "YoOrders",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_YoOrders_YoNotifications_NotificationId",
                table: "YoOrders",
                column: "NotificationId",
                principalTable: "YoNotifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_YoOrders_YoReservations_ReservationId",
                table: "YoOrders",
                column: "ReservationId",
                principalTable: "YoReservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YoOrders_AspNetUsers_EmployeeId",
                table: "YoOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_YoOrders_YoNotifications_NotificationId",
                table: "YoOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_YoOrders_YoReservations_ReservationId",
                table: "YoOrders");

            migrationBuilder.DropIndex(
                name: "IX_YoOrders_EmployeeId",
                table: "YoOrders");

            migrationBuilder.DropIndex(
                name: "IX_YoOrders_NotificationId",
                table: "YoOrders");

            migrationBuilder.DropIndex(
                name: "IX_YoOrders_ReservationId",
                table: "YoOrders");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "YoOrders");

            migrationBuilder.DropColumn(
                name: "NotificationId",
                table: "YoOrders");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "YoOrders");
        }
    }
}
