using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yoko.Migrations
{
    /// <inheritdoc />
    public partial class AddedPhotoInYoService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "YoServices",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "YoServices");
        }
    }
}
