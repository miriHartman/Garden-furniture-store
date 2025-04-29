using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dal_Repository.Migrations
{
    /// <inheritdoc />
    public partial class n3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPay",
                table: "buys",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPay",
                table: "buys");
        }
    }
}
