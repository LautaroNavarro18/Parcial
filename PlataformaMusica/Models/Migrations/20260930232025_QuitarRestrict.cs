using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class QuitarRestrict : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Canciones_Artistas_ArtistaId",
                table: "Canciones");

            migrationBuilder.AddForeignKey(
                name: "FK_Canciones_Artistas_ArtistaId",
                table: "Canciones",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Canciones_Artistas_ArtistaId",
                table: "Canciones");

            migrationBuilder.AddForeignKey(
                name: "FK_Canciones_Artistas_ArtistaId",
                table: "Canciones",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
