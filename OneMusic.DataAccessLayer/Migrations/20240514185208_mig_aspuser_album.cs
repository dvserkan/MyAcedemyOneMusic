using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneMusic.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_aspuser_album : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppuserId",
                table: "Albums",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Albums_AppuserId",
                table: "Albums",
                column: "AppuserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_AspNetUsers_AppuserId",
                table: "Albums",
                column: "AppuserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_AspNetUsers_AppuserId",
                table: "Albums");

            migrationBuilder.DropIndex(
                name: "IX_Albums_AppuserId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "AppuserId",
                table: "Albums");
        }
    }
}
