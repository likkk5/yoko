using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yoko.Migrations
{
    /// <inheritdoc />
    public partial class AddedYoServiceinOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YoServiceinOrders",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YoServiceinOrders", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_YoServiceinOrders_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YoServiceinOrders_YoOrders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "YoOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YoServiceinOrders_YoServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "YoServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_YoServiceinOrders_EmployeeId",
                table: "YoServiceinOrders",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_YoServiceinOrders_OrderId",
                table: "YoServiceinOrders",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YoServiceinOrders");
        }
    }
}
