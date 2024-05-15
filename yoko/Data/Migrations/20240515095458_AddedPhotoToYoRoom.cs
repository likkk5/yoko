using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yoko.Migrations
{
    /// <inheritdoc />
    public partial class AddedPhotoToYoRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "YoRooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "YoRooms");
        }
    }
}
