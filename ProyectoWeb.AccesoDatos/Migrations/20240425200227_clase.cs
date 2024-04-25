using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoWeb.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class clase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "AspNetUsers",
                newName: "Telefono");

            migrationBuilder.AddColumn<string>(
                name: "Materno",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paterno",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Materno",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Paterno",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "AspNetUsers",
                newName: "Direccion");
        }
    }
}
