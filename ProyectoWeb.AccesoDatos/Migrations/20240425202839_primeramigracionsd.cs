using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoWeb.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class primeramigracionsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Materno",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Paterno",
                table: "AspNetUsers",
                newName: "Apellido");

            migrationBuilder.AlterColumn<int>(
                name: "Telefono",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "AspNetUsers",
                newName: "Paterno");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Materno",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
