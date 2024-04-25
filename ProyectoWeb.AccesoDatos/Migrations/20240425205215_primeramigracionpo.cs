using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoWeb.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class primeramigracionpo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "AspNetUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Telefono",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }
    }
}
