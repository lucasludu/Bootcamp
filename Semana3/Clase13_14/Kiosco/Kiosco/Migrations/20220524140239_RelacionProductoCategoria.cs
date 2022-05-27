using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kiosco.Migrations
{
    public partial class RelacionProductoCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Producto_Id",
                table: "Caracteristicas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Caracteristicas_Producto_Id",
                table: "Caracteristicas",
                column: "Producto_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Caracteristicas_Productos_Producto_Id",
                table: "Caracteristicas",
                column: "Producto_Id",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caracteristicas_Productos_Producto_Id",
                table: "Caracteristicas");

            migrationBuilder.DropIndex(
                name: "IX_Caracteristicas_Producto_Id",
                table: "Caracteristicas");

            migrationBuilder.DropColumn(
                name: "Producto_Id",
                table: "Caracteristicas");
        }
    }
}
