using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yoko.Migrations
{
    /// <inheritdoc />
    public partial class AddedEmployeeToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "YoOrders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_YoOrders_EmployeeId",
                table: "YoOrders",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_YoOrders_AspNetUsers_EmployeeId",
                table: "YoOrders",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YoOrders_AspNetUsers_EmployeeId",
                table: "YoOrders");

            migrationBuilder.DropIndex(
                name: "IX_YoOrders_EmployeeId",
                table: "YoOrders");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "YoOrders");
        }
    }
}
