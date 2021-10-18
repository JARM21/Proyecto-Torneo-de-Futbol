using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoFutbol.App.Persistencia.Migrations
{
    public partial class Correccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jugadores_Equipos_EquipoId",
                table: "Jugadores");

            migrationBuilder.AlterColumn<int>(
                name: "EquipoId",
                table: "Jugadores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EquiposId",
                table: "Jugadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Jugadores_Equipos_EquipoId",
                table: "Jugadores",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jugadores_Equipos_EquipoId",
                table: "Jugadores");

            migrationBuilder.DropColumn(
                name: "EquiposId",
                table: "Jugadores");

            migrationBuilder.AlterColumn<int>(
                name: "EquipoId",
                table: "Jugadores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Jugadores_Equipos_EquipoId",
                table: "Jugadores",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
