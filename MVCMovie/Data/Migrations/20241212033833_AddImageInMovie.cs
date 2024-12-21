using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCMovie.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddImageInMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Movie",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Movie");
        }
    }
}
