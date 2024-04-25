using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoWeb.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class InsercionDeTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Clente",
                table: "Clente");

            migrationBuilder.RenameTable(
                name: "Clente",
                newName: "Cliente");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Cliente",
                newName: "Celular");

            migrationBuilder.AddColumn<int>(
                name: "CarnetIdentidad",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadMinima = table.Column<int>(type: "int", nullable: false),
                    PrecioVenta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "CarnetIdentidad",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clente");

            migrationBuilder.RenameColumn(
                name: "Celular",
                table: "Clente",
                newName: "Telefono");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clente",
                table: "Clente",
                column: "Id");
        }
    }
}
