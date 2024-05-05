using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yoko.Migrations
{
    /// <inheritdoc />
    public partial class AddedToServiceInOrderNullEmployeeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YoServiceinOrders_AspNetUsers_EmployeeId",
                table: "YoServiceinOrders");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "YoServiceinOrders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_YoServiceinOrders_AspNetUsers_EmployeeId",
                table: "YoServiceinOrders",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YoServiceinOrders_AspNetUsers_EmployeeId",
                table: "YoServiceinOrders");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "YoServiceinOrders",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_YoServiceinOrders_AspNetUsers_EmployeeId",
                table: "YoServiceinOrders",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
