using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yoko.Migrations
{
    /// <inheritdoc />
    public partial class AddedYoNotifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YoNotifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    NotificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NotificationText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YoNotifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YoNotifications_YoOrders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "YoOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_YoNotifications_OrderId",
                table: "YoNotifications",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YoNotifications");
        }
    }
}
