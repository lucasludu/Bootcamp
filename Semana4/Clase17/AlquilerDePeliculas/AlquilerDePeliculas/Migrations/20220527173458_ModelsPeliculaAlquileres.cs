using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlquilerDePeliculas.Migrations
{
    public partial class ModelsPeliculaAlquileres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlquilerId",
                table: "Peliculas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Alquileres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    PeliculaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquileres", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_AlquilerId",
                table: "Peliculas",
                column: "AlquilerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Peliculas_Alquileres_AlquilerId",
                table: "Peliculas",
                column: "AlquilerId",
                principalTable: "Alquileres",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peliculas_Alquileres_AlquilerId",
                table: "Peliculas");

            migrationBuilder.DropTable(
                name: "Alquileres");

            migrationBuilder.DropIndex(
                name: "IX_Peliculas_AlquilerId",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "AlquilerId",
                table: "Peliculas");
        }
    }
}
