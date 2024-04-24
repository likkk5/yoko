using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yoko.Migrations
{
    /// <inheritdoc />
    public partial class AddedNotificationToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NotificationId",
                table: "YoOrders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_YoOrders_NotificationId",
                table: "YoOrders",
                column: "NotificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_YoOrders_YoNotifications_NotificationId",
                table: "YoOrders",
                column: "NotificationId",
                principalTable: "YoNotifications",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YoOrders_YoNotifications_NotificationId",
                table: "YoOrders");

            migrationBuilder.DropIndex(
                name: "IX_YoOrders_NotificationId",
                table: "YoOrders");

            migrationBuilder.DropColumn(
                name: "NotificationId",
                table: "YoOrders");
        }
    }
}
